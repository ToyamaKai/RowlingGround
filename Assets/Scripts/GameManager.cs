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

    private static bool Goal = false;
    //��]�����ǂ����𔻒f����coroutineBool�BRotateObject�����]���Ă邩�ǂ������������݁APlayerScript�͂��̏󋵂��m�F���Ĉړ��ł��邩�ǂ����𔻒f����B
    public static bool coroutineBool = false;

    //fps��60�ɌŒ肷��
    void Start()
    {
        Application.targetFrameRate = 60;
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
