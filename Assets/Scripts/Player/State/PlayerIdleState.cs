using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Enums;

public class PlayerIdleState : PlayerStates
{
    public override void Init(Player player)
    {
        base.Init(player);
        state = PlayerState.Idle;
    }

    public override void OnEnter()
    {
        base.OnEnter();
    }

    public override void OnUpdate(float deltaTime)
    {
        base.OnUpdate(deltaTime);

        if (player.controller.Move() != Vector3.zero)
        {
            player.controller.ChangeState(nameof(PlayerMoveState));
            return;
        }


    }

    public override void OnExit()
    {
        base.OnExit();
    }
}

