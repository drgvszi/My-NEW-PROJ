﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;   

public class ShowOrHide : MonoBehaviour
{
    public GameObject obj;
    public void Show()
    {
        obj.SetActive(true);
    }
    public void Hide()
    {
        obj.SetActive(false);
    }
}
