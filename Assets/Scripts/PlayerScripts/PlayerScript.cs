using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    private float speed = 7.0f; // �ړ����x
    private Rigidbody rb; // Rigidbody�R���|�[�l���g
    private bool isRunning;
    private bool isRight;//�E�������ǂ���

    Vector3 localAngle;

    [SerializeField]
    Animator playerAnimator;

    void Start()
    {
        // Rigidbody�R���|�[�l���g���L���b�V������
        rb = GetComponent<Rigidbody>();
        transform.Rotate(0,0,0);
        isRight = true;
    }

    void Update()
    {
        //��]���łȂ����A�L�[��-x�ցAD�L�[�ł����+x�Ɉړ�����
        if (!GameManager.coroutineBool)
        {
            if (Input.GetKey(KeyCode.A))
            {
                if(isRight)
                {
                    localAngle = this.transform.localEulerAngles;
                    localAngle.y += 180;
                    this.transform.localEulerAngles = localAngle;
                    isRight = false;
                }
                Runing = true;
                rb.AddForce(transform.forward * speed);
            }
            else if (Input.GetKey(KeyCode.D))
            {
                if (!isRight)
                {
                    localAngle = this.transform.localEulerAngles;
                    localAngle.y += 180;
                    this.transform.localEulerAngles = localAngle;
                    isRight = true;
                }
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
