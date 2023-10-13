using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : SingletonMonoBehaviour<GameManager>
{
    public enum State
    {
        TITLE,
        GAME,
        RESULT
    }

    private State m_state;

    [SerializeField] UIManager m_ui;

    public bool IsTitle { get{ return m_state == State.TITLE; } }
    public bool IsGame { get{ return m_state == State.GAME; } }

    void Start()
    {
        ChangeState(State.TITLE);
    }

    public void ChangeState(State state)
    {
        m_state = state;
        m_ui.ChangeState(state);
    }
}
