using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Enums;

public class PlayerJumpState : PlayerStates
{
    public override void Init(Player player)
    {
        base.Init(player);
        state = PlayerState.Jump;
    }


    public override void OnEnter()
    {
        base.OnEnter();
        player.controller.Jump();
        player.playerAnime.SetTrigger("Jump");
    }

    public override void OnUpdate(float deltaTime)
    {
        base.OnUpdate(deltaTime);
        if (elapsedTime > 1.5f)
        {
            player.controller.ChangeState(nameof(PlayerIdleState));
            return;
        }
    }

    public override void OnExit()
    {
        base.OnExit();
    }
}
