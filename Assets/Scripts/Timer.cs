using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    private int minute;
    private float seconds;

    [SerializeField]
    GameManager m_gameManager;

    private float oldSeconds;
    private Text timerText;

    void Start()
    {
        minute      = 0;
        seconds     = 0f;
        oldSeconds  = 0f;
        timerText = GetComponentInChildren<Text>();
    }

    void Update()
    {
        if(!m_gameManager.GetGoal())
        {
            seconds += Time.deltaTime;
            if (seconds >= 60f)
            {
                minute++;
                seconds = seconds - 60;
            }
            if ((int)seconds != (int)oldSeconds)
            {
                timerText.text = "Time:" + minute.ToString("00") + ":" + ((int)seconds).ToString("00");
            }
            oldSeconds = seconds;
        }
    }
}