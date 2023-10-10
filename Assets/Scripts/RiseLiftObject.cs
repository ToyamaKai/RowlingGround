using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RiseLiftObject : MonoBehaviour
{
    // Start is called before the first frame update
    private const float m_liftSpeed = 0.02f;
    private Transform m_myTransform;
    private Vector3 m_liftPosition;

    void Start()
    {
        m_myTransform = this.transform;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public IEnumerator RiseLift()
    {
        Debug.Log("�J�n");
        yield return new WaitForSeconds(1);
        for (int i = 0; i < 100; i++)
        {
            m_liftPosition = m_myTransform.position;
            m_liftPosition.y += m_liftSpeed;
            m_myTransform.position = m_liftPosition;
            yield return null;
        }
    }
}
