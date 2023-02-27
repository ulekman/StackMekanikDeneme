using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomBoxSpawner : MonoBehaviour
{

    public Transform SpawnBoxes;
    public GameObject[] BoxPrefabs;
    public GameObject SpawnBox;
    // Start is called before the first frame update
    void Start()
    {
       RespawnBox();
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("CollectBoxBlue"))
        {
            Invoke("RespawnBox", 1f);
        }
    }

    private void RespawnBox()
    {   
        int randBox = Random.Range(0, BoxPrefabs.Length);
        Instantiate(BoxPrefabs[randBox], SpawnBoxes.position, transform.rotation);
    }


}
