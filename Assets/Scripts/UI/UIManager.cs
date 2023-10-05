using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    [SerializeField]
    private GameObject m_titleUI;

    [SerializeField]
    private GameObject m_gameUI;

    [SerializeField]
    private GameObject m_resultUI;

    public void ChangeState(GameManager.State state)
    {
        m_titleUI.gameObject.SetActive(state == GameManager.State.TITLE);
        m_gameUI.gameObject.SetActive(state == GameManager.State.GAME);
        m_resultUI.gameObject.SetActive(state == GameManager.State.RESULT);
    }
}
