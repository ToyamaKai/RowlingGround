using System.Collections;
using UnityEngine;

public class RotateObject : MonoBehaviour
{
    //回転中かどうか
    private bool coroutineBool = false;

    [SerializeField] MeshRendererSwitch m_sideMeshRendererSwitch;
    [SerializeField] MeshRendererSwitch m_frontMeshRendererSwitch;


    void Update()
    {
        //PlayerScriptにて、GameManagerのcoroutineBoolを参照して回転中には移動できないようにするため、GameManagerのcoroutinBoolに書き込む
        if (coroutineBool)
        {
            GameManager.coroutineBool = true;
        }
        else
        {
            GameManager.coroutineBool = false;
        }

        //ステージを回転させるためのキー入力受付&処理
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

    //回転を複数回行った際に、小数点以下でのずれが生じ、コースアウトしてしまうのを防ぐための四捨五入関数
    void Round_off()
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

        transform.eulerAngles = new Vector3(x,y,z);
    }

    IEnumerator Rotate(GameManager.InputGetKey Key)
    {
        var DirectionRotation = Vector3.forward;

        switch(Key)
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

        m_sideMeshRendererSwitch.ChangeDirection();
        m_frontMeshRendererSwitch.ChangeDirection();
    }
}