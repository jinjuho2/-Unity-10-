using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class State<T> where T : MonoBehaviour
{

    protected float elapsedTime;

    public State() { }

    public virtual void Init(T Owner) { }

    public virtual void OnEnter()
    {
        elapsedTime = 0;
        Debug.Log("State Entered: " + this.GetType().Name);
    }

    public virtual void OnExit() { }
    public virtual void OnUpdate(float deltaTime)
    {
        elapsedTime += deltaTime;
    }

    public virtual void OnFixedUpdate()
    {
        
    }

}
