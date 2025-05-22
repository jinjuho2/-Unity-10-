using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : BaseController<Player>
{
    private Player player;

    public Vector3 inputDir;

   
    public PlayerController(State<Player> initState, Player player) : base(initState, player)
    {
        this.player = player;
    }

    public override void OnUpdate(float deltaTime)
    {
        base.OnUpdate(deltaTime);
        Move();
    }

    public Vector3 Move()
    {
        
        inputDir.x = Input.GetAxisRaw("Horizontal");
        inputDir.y = Input.GetAxisRaw("Vertical");
        return inputDir;
    }

    


}
