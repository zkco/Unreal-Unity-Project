using System;
using UnityEngine;

public class CharaAnimationController : AnimationController
{
    private static readonly int isMoving = Animator.StringToHash("isMoving");
    private static readonly int isDead = Animator.StringToHash("isDead");
    private static readonly int Fire = Animator.StringToHash("fire");

    private CharaHealthController healthController;

    protected override void Awake()
    {
        base.Awake();
        healthController = GetComponent<CharaHealthController>();
    }

    private void Start()
    {
        controller.OnMoveEvent += Move;
        controller.OnFireEvent += Shoot;

        if (healthController != null)
        {
            healthController.OnDeath += Die;
        }
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
        animator.SetBool(isDead, true);
    }
}