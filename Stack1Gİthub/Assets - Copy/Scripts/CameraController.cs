using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Transform target;
    public Camera main;
    public Camera startCam;

    // Start is called before the first frame update
    void Start()
    {
        startCam.enabled = true;
        main.enabled = false;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Invoke("mainCamActive", 1f);
        transform.position = new Vector3(target.transform.position.x, transform.position.y, target.transform.position.z -10f);
    }

    public void mainCamActive()
    {
        main.enabled = true;
        startCam.enabled = false;
    }
}
