using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    private float speed = 100.0f; // �ړ����x
    private Rigidbody rb; // Rigidbody�R���|�[�l���g

    void Start()
    {
        // Rigidbody�R���|�[�l���g���L���b�V������
        rb = GetComponent<Rigidbody>();
        transform.Rotate(0,0,0);
    }

    void Update()
    {
        //��]���łȂ����A�L�[��-x�ցAD�L�[�ł����+x�Ɉړ�����
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
