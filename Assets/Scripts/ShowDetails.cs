using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowDetails : MonoBehaviour
{
    public GameObject obj;
    public int ok=0;

    public void ShowHide()
    {
        if (ok == 0)
        {
            obj.SetActive(true);
            ok = 1;
        }
        else
        {
            obj.SetActive(false);
            ok = 0;
        }

    }
   
}
