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

    //回転中かどうかを判断するcoroutineBool。RotateObjectから回転してるかどうかを書き込み、PlayerScriptはその状況を確認して移動できるかどうかを判断する。
    public static bool coroutineBool = false;

    //fpsを60に固定する
    void Start()
    {
        Application.targetFrameRate = 60;
    }

    // Update is called once per frame
}
