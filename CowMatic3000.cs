using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CowMatic3000 : MonoBehaviour
{
    int count = 10;

    [SerializeField] Animator animator;

    private void Start()
    {
        if (!animator)
        {
            Debug.LogError("Animator is not defined");
            return;
        }
        animator.speed = 2;
        count = 10;
        SetAnimation();

    }

    private void SetAnimation()
    {
        if (count < 1) return;
        animator.Play("ProcessCow");
        count--;
    }

    public void onAnimationEnd()
    {
        SetAnimation();
    }
}
