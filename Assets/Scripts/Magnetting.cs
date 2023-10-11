using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Magnetting : MonoBehaviour
{
    [SerializeField] private Rigidbody m_playerRigidBody;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(!m_playerRigidBody.useGravity)
        {
            m_playerRigidBody.velocity = Vector3.zero;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "MagneticGround")
        {
            m_playerRigidBody.useGravity = false; 
        }
    }
    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.tag == "MagneticGround")
        {
            m_playerRigidBody.useGravity = true;
        }
    }
}
