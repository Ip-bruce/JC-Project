using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CharacterAnimation : MonoBehaviour
{
   
      //bool isWalking = false;
     Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();    
    }

    // Update is called once per frame
    void Update()
    {
        
        AnimationController();

    }

    public void AnimationController()
    {
        if(Input.GetKey("d"))
        {
            
            animator.SetFloat("Horizontal",1.0f);
            animator.SetBool("isWalking",true);
            animator.SetBool("isForward",true);
        }
        if(Input.GetKey("a"))
        {
           
            animator.SetFloat("Horizontal",-1.0f);
            animator.SetBool("isWalking",true);
            animator.SetBool("isForward",true);
        }
        else
        {
             animator.SetFloat("Horizontal",0f);
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
