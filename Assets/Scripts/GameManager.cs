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
    
    public static bool coroutineBool = false;   //回転中かどうかを判断するcoroutineBool。RotateObjectから回転してるかどうかを書き込み、PlayerScriptはその状況を確認して移動できるかどうかを判断する。

    private int m_goalPoint;
    //fpsを60に固定する
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
