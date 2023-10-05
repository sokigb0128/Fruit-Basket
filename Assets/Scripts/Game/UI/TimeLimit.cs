using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TimeLimit : MonoBehaviour
{
    TextMeshProUGUI text;
    float time = 0.0f;

    readonly float START_TIME = 10.0f;

    void Start()
    {
        text = GetComponent<TextMeshProUGUI>();
        time = START_TIME;
    }

    void Update()
    {
        if (!GameManager.Instance.IsGame()) return;

        time -= Time.deltaTime;
        text.text = "TimeLimit : " + (int)time;

        if(time <= 0.0f)
        {
            GameManager.Instance.ChangeState(GameManager.State.RESULT);
            time = START_TIME;
        }
    }
}
