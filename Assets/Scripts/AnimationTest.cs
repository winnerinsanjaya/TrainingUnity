using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationTest : MonoBehaviour
{
    public Animator animator;


    public void SetAnimBool(string name, bool condition)
    {
        animator.SetBool(name, condition);
    }
}
