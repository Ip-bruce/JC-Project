using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CharacterAnimation : MonoBehaviour
{
   
      //bool isWalking = false;
     Animator animator;
     float Horizontal;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();    
    }

    // Update is called once per frame
    void Update()
    {
        Horizontal = animator.GetFloat("Horizontal");
        AnimationController();

    }

    public void AnimationController()
    {
        if(Input.GetKey("d"))
        {
            Horizontal++;
            animator.SetBool("isWalking",true);
            animator.SetBool("isForward",true);
        }
        else
        {
            Horizontal = 0;
            animator.SetBool("isWalking",false);
            animator.SetBool("isForward",false);
        }

        
         //isWalking = animator.GetBool("isWalking");
        // animator.SetBool(isWalking,true);
        if(Input.GetKey("w"))
        {
            animator.SetBool("isWalking",true);
            animator.SetBool("isForward",true);

        }

        else
        {
          animator.SetBool("isWalking",false);
          animator.SetBool("isForward",false);
            
        }

        if(Input.GetKey("s"))
        {
           animator.SetBool("isWalking",true);
           animator.SetBool("isForward",false);

        }

        
    }
}
