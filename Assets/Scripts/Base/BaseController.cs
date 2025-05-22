using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseController<T> where T : MonoBehaviour
{
    public Dictionary<string, State<T>> registedState = new Dictionary<string, State<T>>();

    protected State<T> currentState;

    protected State<T> previousState;

    public BaseController(State<T> initState, T Owner)
    {
        RegistedState(initState, Owner);

        currentState = initState;
        currentState.OnEnter();
    }

    public virtual void OnUpdate(float deltaTime)
    {
        currentState?.OnUpdate(deltaTime);
    }

    public virtual void OnFixedUpdate()
    {
        currentState?.OnFixedUpdate();
    }

    public virtual void RegistedState(State<T> state, T Owner)
    {
        state.Init(Owner);
        registedState.Add(state.GetType().Name, state);
    }

    public virtual void ChangeState(string newState)
    {
        if (registedState.ToString() == newState) return;

        currentState?.OnExit();

        previousState = currentState;

        currentState = registedState[newState];
        currentState.OnEnter();
    }

    public State<T> GetState()
    {
        return  currentState;
    }

}