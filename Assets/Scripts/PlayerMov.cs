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
        mvm = Vector2.zero;
        mvm.x=  Input.GetAxisRaw("Horizontal");
        mvm.y = Input.GetAxisRaw("Vertical");
        if (mvm != Vector2.zero)
        {
            animator.SetFloat("Horizontal", mvm.x);
            animator.SetFloat("Vertical", mvm.y);
            animator.SetBool("moving", true);
            animator.SetFloat("Speed", mvm.sqrMagnitude);
        }
        else
        {
            animator.SetBool("moving", false);
        }
    }
    void FixedUpdate()
    {
        RB.MovePosition(RB.position+mvm*moveSpeed*Time.fixedDeltaTime);
    }
}
