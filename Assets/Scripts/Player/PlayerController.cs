using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : BaseController<Player>
{
    private Player player;

    public Vector3 inputDir;
    public int rayDistance = 2;

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

    public void Jump()
    {
        
        player.rb.AddForce(Vector3.up * player.playerStat.jumpForce, ForceMode.Impulse);

    }

    public bool IsGround()
    {
        Ray ray = new Ray(player.transform.position, Vector3.down);
        Debug.DrawRay(player.transform.position, Vector3.down * rayDistance, Color.red);
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit, 0.2f))
        {
            if (hit.collider.CompareTag("Ground"))
            {
                return true;
            }
        }

        return false;
    }


}
