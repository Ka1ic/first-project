using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class anim : MonoBehaviour
{
    private Animator Anim;
    void Start()
    {
        Anim = GetComponent<Animator>();
    }
     void Update()
    {
     if(Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.RightArrow))
        {
            Anim.SetBool("i", true);
        }
        else
        {
            Anim.SetBool("i", false);
        }
    }
}
