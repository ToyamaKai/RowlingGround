using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    //回転中かどうかを判断するcoroutineBool。RotateObjectから回転してるかどうかを書き込み、PlayerScriptはその状況を確認して移動できるかどうかを判断する。
    public static bool coroutineBool = false;
    // Start is called before the first frame update
    void Start()
    {
        //fpsを60に固定する
        Application.targetFrameRate = 60;
    }

    // Update is called once per frame
}
