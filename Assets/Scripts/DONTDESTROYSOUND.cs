using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DONTDESTROYSOUND : MonoBehaviour
{
    private static DONTDESTROYSOUND instance;
    void Awake()
    {
        if (instance != null)
        {
            Destroy(gameObject);
        }
        else
        {
            instance = this;
            DontDestroyOnLoad(this.gameObject);
        }
    }
}