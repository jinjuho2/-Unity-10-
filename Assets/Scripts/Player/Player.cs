using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using Enums;
using System;

public class Player : MonoBehaviour
{
    private PlayerController Controller { get { return controller; } }
    public PlayerController controller;
    
    public InteractionController interactionController;
    public Rigidbody rb;
    
    public ItemData itemData;
    public Action addItem;

    public PlayerStat playerStat;

    public Animator playerAnime;

    private void Awake()
    {
        Init();
    }

    private void Update()
    {
        controller?.OnUpdate(Time.deltaTime);
    }
    private void FixedUpdate()
    {
        controller?.OnFixedUpdate();
    }


    public void Init()
    {
        rb = GetComponent<Rigidbody>();
        playerStat = GetComponent<PlayerStat>();
        playerAnime = GetComponentInChildren<Animator>();
        interactionController = GetComponent<InteractionController>();
        ControllerRegiser();
    }

    public void ControllerRegiser()
    {
        controller = new PlayerController(new PlayerIdleState(), this);
        controller.RegistedState(new PlayerMoveState(), this);
        controller.RegistedState(new PlayerJumpState(), this);
    }

    public void Get()
    {
        Destroy(gameObject);
    }

    

    

   
}
