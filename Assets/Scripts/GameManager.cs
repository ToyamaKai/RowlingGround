using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    //��]�����ǂ����𔻒f����coroutineBool�BRotateObject�����]���Ă邩�ǂ������������݁APlayerScript�͂��̏󋵂��m�F���Ĉړ��ł��邩�ǂ����𔻒f����B
    public static bool coroutineBool = false;
    // Start is called before the first frame update
    void Start()
    {
        //fps��60�ɌŒ肷��
        Application.targetFrameRate = 60;
    }

    // Update is called once per frame
}
