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
    //‰ñ“]’†‚©‚Ç‚¤‚©‚ğ”»’f‚·‚écoroutineBoolBRotateObject‚©‚ç‰ñ“]‚µ‚Ä‚é‚©‚Ç‚¤‚©‚ğ‘‚«‚İAPlayerScript‚Í‚»‚Ìó‹µ‚ğŠm”F‚µ‚ÄˆÚ“®‚Å‚«‚é‚©‚Ç‚¤‚©‚ğ”»’f‚·‚éB
    public static bool coroutineBool = false;

    //fps‚ğ60‚ÉŒÅ’è‚·‚é
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
