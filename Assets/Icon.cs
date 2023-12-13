using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Icon : MonoBehaviour
{
    public Animator animator;
    private void OnMouseEnter()
    {
        animator.SetBool("SelectionActive", true);
    }
    private void OnMouseExit()
    {
        animator.SetBool("SelectionActive", false);
    }
}
