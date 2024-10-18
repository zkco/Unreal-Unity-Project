using System;
using UnityEngine;

public class CharaAnimationController : AnimationController
{
    private static readonly int isMoving = Animator.StringToHash("isMoving");
    private static readonly int isDead = Animator.StringToHash("isDead");
    private static readonly int Fire = Animator.StringToHash("fire");

    protected override void Awake()
    {
        base.Awake();
        controller = GetComponent<CharaController>();
    }

    private void Start()
    {
        controller.OnMoveEvent += Move;
        controller.OnFireEvent += Shoot;
        controller.OnDeath += Die;
        controller.OnRevive += Revive;
    }

    private void Move(Vector2 vector)
    {
        animator.SetBool(isMoving, vector.magnitude > 0f);
    }

    private void Shoot()
    {
        animator.SetTrigger(Fire);
    }

    private void Die()
    {
        Debug.Log("Die");
        animator.SetBool(isDead, true);
    }

    private void Revive()
    {
        Debug.Log("Revive");
        animator.SetBool(isDead, false);
    }
}