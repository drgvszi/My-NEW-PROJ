using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMov : MonoBehaviour
{
    public float moveSpeed = 5f;
    public Rigidbody2D RB;
    Vector2 mvm;
    public Animator animator;
    
    // Update is called once per frame
    void Update()
    {
        mvm.x=Input.GetAxisRaw("Horizontal");
        mvm.y = Input.GetAxisRaw("Vertical");
        animator.SetFloat("Horizontal", mvm.x);
        animator.SetFloat("Vertical", mvm.y);
        animator.SetFloat("Speed", mvm.sqrMagnitude);
      
    }
    void FixedUpdate()
    {
        RB.MovePosition(RB.position+mvm*moveSpeed*Time.fixedDeltaTime);
    }
}
