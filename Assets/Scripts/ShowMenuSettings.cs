using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowMenuSettings : MonoBehaviour
{
    public GameObject obj;
    public GameObject obj1;

    public void ShowSettings()
    {
        obj.SetActive(true);
        obj1.SetActive(false);
    }
    public void ShowMenuButtons()
    {
        obj.SetActive(false);
        obj1.SetActive(true);
    }

}
