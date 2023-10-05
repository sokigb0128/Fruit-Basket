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

    void Start()
    {
        m_state = State.TITLE;
    }

    public bool IsGame()
    {
        return m_state == State.GAME;
    }

    public void ChangeState(State state)
    {
        m_state = state;
        m_ui.ChangeState(state);
    }
}
