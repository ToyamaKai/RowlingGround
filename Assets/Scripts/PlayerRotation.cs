using System.Collections;
using UnityEngine;

public class PlayerRotation : MonoBehaviour
{

    void Update()
    {

        //ステージを回転させるためのキー入力受付&処理
        if (Input.GetKey("q"))
        {
            Rotate(GameManager.InputGetKey.QKey);
        }

        if (Input.GetKey("e"))
        {
            Rotate(GameManager.InputGetKey.EKey);
        }

        if (Input.GetKey("up"))
        {
            Rotate(GameManager.InputGetKey.UpKey);
        }

        if (Input.GetKey("down"))
        {
            Rotate(GameManager.InputGetKey.DownKey);
        }

        if (Input.GetKey("left"))
        {
            Rotate(GameManager.InputGetKey.LeftKey);
        }

        if (Input.GetKey("right"))
        {
            Rotate(GameManager.InputGetKey.RightKey);
        }
    }


    //四捨五入関数
    private void Round_off()
    {
        // 自身のrotationを取得する
        float x = transform.eulerAngles.x;
        float y = transform.eulerAngles.y;
        float z = transform.eulerAngles.z;

        Quaternion rotation = transform.rotation;

        // x, y, zが小数点以下がある場合には四捨五入する
        x = Mathf.Round(x);
        y = Mathf.Round(y);
        z = Mathf.Round(z);

        transform.eulerAngles = new Vector3(x, y, z);
    }

    void Rotate(GameManager.InputGetKey Key)
    {
        var DirectionRotation = Vector3.forward;

        switch (Key)
        {
            case GameManager.InputGetKey.QKey:
                DirectionRotation = Vector3.down;
                break;
            case GameManager.InputGetKey.EKey:
                DirectionRotation = Vector3.up;
                break;
            case GameManager.InputGetKey.UpKey:
                DirectionRotation = Vector3.left;
                break;
            case GameManager.InputGetKey.DownKey:
                DirectionRotation = Vector3.right;
                break;
            case GameManager.InputGetKey.LeftKey:
                DirectionRotation = Vector3.back;
                break;
            case GameManager.InputGetKey.RightKey:
                DirectionRotation = Vector3.forward;
                break;
            default:
                break;
        }

        transform.RotateAround(transform.position, DirectionRotation, 1);

        Round_off();
    }
}