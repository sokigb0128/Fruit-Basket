using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Title : MonoBehaviour
{
    void Update()
    {
        if(Input.GetKey(KeyCode.Space))
        {
            GameManager.Instance.ChangeState(GameManager.State.GAME);
        }
    }
}
