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
        player.interactionController.IsInteract();

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

        if (Input.GetKeyDown(KeyCode.F) && player.interactionController.curInteractable != null)
        {
            player.interactionController.InteractInput(player);
            Debug.Log("Get");
            return;
        }

        if (Input.GetKeyDown(KeyCode.E))
        {
            player.inventory.UseItem(player);
        }
    }

    public override void OnExit()
    {
        base.OnExit();
    }
}

