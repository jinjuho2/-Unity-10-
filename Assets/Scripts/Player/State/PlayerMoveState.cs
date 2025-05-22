using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Enums;
using UnityEngine.InputSystem;
using static UnityEditor.Timeline.TimelinePlaybackControls;

public class PlayerMoveState : PlayerStates
{

    private Vector3 curMovemenetInput;

    public override void Init(Player player)
    {
        base.Init(player);
        state = PlayerState.Move;
    }

    public override void OnEnter()
    {
       base.OnEnter();
       player.playerAnime.SetBool("WalkForward", true);
    }

    public override void OnUpdate(float deltaTime)
    {
        base.OnUpdate(deltaTime);
        curMovemenetInput = player.controller.Move();
        if (curMovemenetInput.y < 0)
        {
            player.playerAnime.SetBool("WalkBackward", true);
        }
        if (curMovemenetInput == Vector3.zero)
        {
            player.controller.ChangeState(nameof(PlayerIdleState));

            return;
        }

        if (Input.GetKeyDown(KeyCode.Space) && player.controller.IsGround())
        {
            player.controller.ChangeState(nameof(PlayerJumpState));
            return;
        }
    }

    public override void OnFixedUpdate()
    {
        Vector3 moveDirection = player.transform.forward * player.controller.inputDir.y + player.transform.right * player.controller.inputDir.x;
        player.rb.velocity = moveDirection * player.playerStat.moveSpeed;

    }

    public override void OnExit()
    {
        base.OnExit();
    }




}