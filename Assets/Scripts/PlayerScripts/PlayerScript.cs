using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    private float speed = 10.0f; // �ړ����x
    private Rigidbody rb; // Rigidbody�R���|�[�l���g
    private bool isRunning;

    [SerializeField]
    Animator playerAnimator;

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

    //�A�j���[�V������
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
