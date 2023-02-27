using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private Rigidbody rigidBody;
    [SerializeField] private FloatingJoystick joystick;
    [SerializeField] private Animator animator;
    [SerializeField] private float moveSpeed;

    private Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponentInChildren<Animator>();
    }  

    // Update is called once per frame
    void FixedUpdate()
    {
        rigidBody.velocity = new Vector3(joystick.Horizontal * moveSpeed, rigidBody.velocity.y, joystick.Vertical * moveSpeed); 

        if (joystick.Horizontal != 0 || joystick.Vertical != 0)
        {
            transform.rotation = Quaternion.LookRotation(rigidBody.velocity);
            Run();
        }
        else
        {
            Idle();

        }
    }

    private void Idle()
    {
        anim.SetFloat("Running", 0f, 0.2f, Time.deltaTime);
    }

    private void Run()
    {
        anim.SetFloat("Running", 1f, 0.2f, Time.deltaTime);
    }
}

