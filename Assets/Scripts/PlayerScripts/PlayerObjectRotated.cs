using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerObjectRotated : MonoBehaviour
{
    //��]�����ǂ���
    private bool coroutineBool = false;


    void Update()
    {
        //PlayerScript�ɂāAGameManager��coroutineBool���Q�Ƃ��ĉ�]���ɂ͈ړ��ł��Ȃ��悤�ɂ��邽�߁AGameManager��coroutinBool�ɏ�������
        if (coroutineBool)
        {
            GameManager.coroutineBool = true;
        }
        else
        {
            GameManager.coroutineBool = false;
        }

        //�X�e�[�W����]�����邽�߂̃L�[���͎�t&����
        if (Input.GetKeyDown("q"))
        {
            if (!coroutineBool)
            {
                coroutineBool = true;
                StartCoroutine(Rotate(GameManager.InputGetKey.QKey));
            }
        }

        if (Input.GetKeyDown("e"))
        {
            if (!coroutineBool)
            {
                coroutineBool = true;
                StartCoroutine(Rotate(GameManager.InputGetKey.EKey));
            }
        }

        if (Input.GetKeyDown("up"))
        {
            if (!coroutineBool)
            {
                coroutineBool = true;
                StartCoroutine(Rotate(GameManager.InputGetKey.UpKey));
            }
        }

        if (Input.GetKeyDown("down"))
        {
            if (!coroutineBool)
            {
                coroutineBool = true;
                StartCoroutine(Rotate(GameManager.InputGetKey.DownKey));
            }
        }

        if (Input.GetKeyDown("left"))
        {
            if (!coroutineBool)
            {
                coroutineBool = true;
                StartCoroutine(Rotate(GameManager.InputGetKey.LeftKey));
            }
        }

        if (Input.GetKeyDown("right"))
        {
            if (!coroutineBool)
            {
                coroutineBool = true;
                StartCoroutine(Rotate(GameManager.InputGetKey.RightKey));
            }
        }
    }

    //��]�𕡐���s�����ۂɁA�����_�ȉ��ł̂��ꂪ�����A�R�[�X�A�E�g���Ă��܂��̂�h�����߂̎l�̌ܓ��֐�
    void Round_off()
    {
        // ���g��rotation���擾����

        float x = transform.eulerAngles.x;
        float y = transform.eulerAngles.y;
        float z = transform.eulerAngles.z;

        Quaternion rotation = transform.rotation;

        // x, y, z�������_�ȉ�������ꍇ�ɂ͎l�̌ܓ�����
        x = Mathf.Round(x);
        y = Mathf.Round(y);
        z = Mathf.Round(z);

        transform.eulerAngles = new Vector3(x, y, z);
    }

    IEnumerator Rotate(GameManager.InputGetKey Key)
    {
        var DirectionRotation = Vector3.forward;

        switch (Key)
        {
            case GameManager.InputGetKey.QKey:
                DirectionRotation = Vector3.up;
                break;
            case GameManager.InputGetKey.EKey:
                DirectionRotation = Vector3.down;
                break;
            case GameManager.InputGetKey.UpKey:
                DirectionRotation = Vector3.right;
                break;
            case GameManager.InputGetKey.DownKey:
                DirectionRotation = Vector3.left;
                break;
            case GameManager.InputGetKey.LeftKey:
                DirectionRotation = Vector3.forward;
                break;
            case GameManager.InputGetKey.RightKey:
                DirectionRotation = Vector3.back;
                break;
            default:
                break;
        }

        yield return new WaitForSeconds(0.6f);

        for (int turn = 0; turn < 90; turn++)
        {
            transform.RotateAround(transform.position, DirectionRotation, 1);
            yield return new WaitForSeconds(0.01f);
        }

        Round_off();

        coroutineBool = false;
    }
}
