using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    private float speed = 100.0f; // 移動速度
    private Rigidbody rb; // Rigidbodyコンポーネント

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
                rb.AddForce(-transform.right * speed);
            }
            else if (Input.GetKey(KeyCode.D))
            {
                rb.AddForce(transform.right * speed);
            }

        }
    }
}
