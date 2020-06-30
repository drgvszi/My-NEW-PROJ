using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DAMAGE : MonoBehaviour
{
    public PlayerHealth iaudmg;
    public void OnTriggerEnter2D()
    {
        iaudmg.TakeDMG(20);
        
    }
}
