using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponAttack : MonoBehaviour
{
    public Animator animator;
    public float delay = 0.3f;
    public bool attackBlocked;
    public bool IsAttacking { get; private set; }

    public void ResetIsAttacking()
    {
        IsAttacking = false;
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (attackBlocked)
                return;
            animator.SetTrigger("Attack");
            IsAttacking = true;
            attackBlocked = true;
            StartCoroutine(DelayAttack());
        }
    }
    private IEnumerator DelayAttack()
    {
        yield return new WaitForSeconds(delay);
        attackBlocked = false;
    }
}