using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RiseLiftObject : MonoBehaviour
{
    // Start is called before the first frame update
    private float m_liftSpeed = 0.02f;
    private Transform m_myTransform;
    private Vector3 m_liftPosition;

    private bool isRise;
    private bool isMoving;

    void Start()
    {
        m_myTransform = this.transform;
        isRise = false;
        isMoving = false;
    }

    // Update is called once per frame
    void Update()
    {

    }
    public IEnumerator RiseLift()
    {
        isMoving = true;
        if(!isRise)
        {
            isRise = true;
            m_liftSpeed = 0.02f;
        }
        else
        {
            isRise = false;
            m_liftSpeed = -0.02f;
        }

        yield return new WaitForSeconds(1);

        for (int i = 0; i < 100; i++)
        {
            m_liftPosition = m_myTransform.localPosition;
            m_liftPosition.y += m_liftSpeed;
            m_myTransform.localPosition = m_liftPosition;
            yield return null;
        }

        isMoving = false;
    }

    public bool GetIsMoving()
    {
        return isMoving;
    }
}
