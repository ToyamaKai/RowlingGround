using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LiftStarting : MonoBehaviour
{
    [SerializeField] RiseLiftObject m_riseLiftObject;
    private bool m_liftIsStart = false;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            if (!m_liftIsStart && !m_riseLiftObject.GetIsMoving())
            {
                m_liftIsStart = true;
                StartCoroutine(m_riseLiftObject.RiseLift());
                
            }
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            if (m_liftIsStart && !m_riseLiftObject.GetIsMoving())
            {
                m_liftIsStart = false;
            }
        }
    }
}
