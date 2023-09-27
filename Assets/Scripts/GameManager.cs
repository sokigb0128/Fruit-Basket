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

    void Start()
    {
        m_state = State.TITLE;
    }

    public bool IsTitle()
    {
        return m_state == State.TITLE;
    }

    public void SetState(State state)
    {
        m_state = state;
    }
}
