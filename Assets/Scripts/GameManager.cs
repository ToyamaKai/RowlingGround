using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public enum InputGetKey
    {
        AKey,
        DKey,
        QKey,
        EKey,
        LeftKey,
        RightKey,
        UpKey,
        DownKey,
    }

    private static bool         Goal;
    private static GameObject   m_player;
    
    public static bool coroutineBool = false;   //��]�����ǂ����𔻒f����coroutineBool�BRotateObject�����]���Ă邩�ǂ������������݁APlayerScript�͂��̏󋵂��m�F���Ĉړ��ł��邩�ǂ����𔻒f����B

    private int m_goalPoint;
    //fps��60�ɌŒ肷��
    void Start()
    {
        Application.targetFrameRate = 60;
        m_goalPoint = 0;
        Goal = false;
    }

    public bool GetGoal()
    {
        return Goal;
    }

    public void SetGoal(bool IsGoal)
    {
        Goal = IsGoal;
    }
}
