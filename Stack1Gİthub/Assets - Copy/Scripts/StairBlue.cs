using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StairBlue : MonoBehaviour
{

    public Transform SpawnStairs;
    public GameObject StepPrefabBlue;

    public StackManager script;

    bool isThereAnyLeft;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("CollectBoxBlue"))
        {
            SpawnStep();
        }
    }

    private void SpawnStep()
    {

        Instantiate(StepPrefabBlue, SpawnStairs.position, transform.rotation);
        isThereAnyLeft = false;

    }
}
