using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StacKK : MonoBehaviour
{

    public float yPos = 1f;
    public Transform backPos;
    public  GameObject StepPrefabBlue;
    public Transform SpawnStairs;

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
        if (other.gameObject.CompareTag("PickBlue")){
            AddBack(other.gameObject);
        }

        if (other.gameObject.CompareTag("Stair"))
        {
            Stairs(other.gameObject);
        }

    }

    private void Stairs(GameObject stairObj)
    {
        if (backPos.transform.childCount > 0)
        {
            MeshRenderer mesh = stairObj.GetComponent<MeshRenderer>();
            mesh.enabled = true;
            int obstacleNumber = backPos.transform.childCount - 1;
            Destroy(backPos.GetChild(obstacleNumber).gameObject);
            stairObj.GetComponent<BoxCollider>().enabled = false;

            
        } 
    }

    private void AddBack(GameObject obj)
    {
        obj.transform.SetParent(backPos.transform);
        obj.transform.rotation = backPos.rotation;
        obj.transform.position = new Vector3(backPos.position.x, yPos, backPos.position.z);
        yPos += 0.2f;
    }


}
