using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Enums;
using Unity.VisualScripting;

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
        player.playerAnime.SetBool("WalkForward", false);
        player.playerAnime.SetBool("WalkBackward", false);

    }

    public override void OnUpdate(float deltaTime)
    {
        base.OnUpdate(deltaTime);

        if (player.controller.Move() != Vector3.zero)
        {
            player.controller.ChangeState(nameof(PlayerMoveState));
            return;
        }

        if (Input.GetKeyDown(KeyCode.Space) && player.controller.IsGround())
        {
            player.controller.ChangeState(nameof(PlayerJumpState));
            return;
        }


    }

    public override void OnExit()
    {
        base.OnExit();
    }
}

