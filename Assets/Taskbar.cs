using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Taskbar : MonoBehaviour
{
    public Animator animator;
    public bool active;
    private void OnMouseEnter()
    {
        active = true;
        animator.SetBool("Active", true);
    }
    private void OnMouseExit()
    {
        active = false;
        animator.SetBool("Active", false);
    }
}
