using System.Collections.Generic;
using UnityEngine;

public class StackManager : MonoBehaviour
{
    

    public List<GameObject> Boxes = new List<GameObject>();
    
    
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
        if (other.gameObject.CompareTag("PickBlue"))
        {
            other.gameObject.transform.SetParent(transform);
            other.gameObject.GetComponent<BoxCollider>().enabled = false;
            other.gameObject.transform.localPosition = new Vector3(gameObject.transform.localPosition.x, Boxes[Boxes.Count - 1].transform.localPosition.y + 1.5f, gameObject.transform.localPosition.z);
            Boxes.Add(other.gameObject);
        }
         
               
        
     }

   
}



    
    

