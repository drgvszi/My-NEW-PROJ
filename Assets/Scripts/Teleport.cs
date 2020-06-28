using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : MonoBehaviour
{
    public GameObject obj;
    public GameObject obj1;
    public Collider2D coll;
    public Collider2D coll1;
    public bool ok = false;
    
    private void OnTriggerEnter2D(Collider2D other)
    {
        obj.SetActive(false);
        obj1.SetActive(true);
      
    }
    private void OnTriggerExit2D(Collider2D other)
    {
       
    }

}
