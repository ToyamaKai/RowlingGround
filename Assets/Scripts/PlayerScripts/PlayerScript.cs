using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    private float speed = 10.0f; // 移動速度
    private Rigidbody rb; // Rigidbodyコンポーネント
    private bool isRunning;

    [SerializeField]
    Animator playerAnimator;

    void Start()
    {
        // Rigidbodyコンポーネントをキャッシュする
        rb = GetComponent<Rigidbody>();
        transform.Rotate(0,0,0);
    }

    void Update()
    {
        //回転中でなければAキーで-xへ、Dキーであれば+xに移動する
        if (!GameManager.coroutineBool)
        {
            if (Input.GetKey(KeyCode.A))
            {
                Runing = true;
                rb.AddForce(-transform.forward * speed);
            }
            else if (Input.GetKey(KeyCode.D))
            {
                Runing = true;
                rb.AddForce(transform.forward * speed);
            }
            else
            {
                Runing = false;
            }

        }
    }

    //アニメーション類
    bool Runing
    {
        get { return isRunning; }
        set
        {
            if(value != isRunning)
            {
                isRunning = value;
                playerAnimator.SetBool("Running", isRunning);
            }
        }
    }
}
