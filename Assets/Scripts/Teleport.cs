using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : MonoBehaviour
{
    public GameObject obj;
    public GameObject obj1;
    public Collider2D coll;
    public int ok = 0;
    void Update()
    {
        coll.isTrigger = true; 
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        obj.SetActive(false);
        obj1.SetActive(true);
        coll.isTrigger = false;
    }
   


}
