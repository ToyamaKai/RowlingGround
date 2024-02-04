using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GoalScript : MonoBehaviour
{
    [SerializeField]
    private GameManager m_gameManager;

    [SerializeField]
    private Text        m_text;

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            if(!m_gameManager.GetGoal())
            {
                m_gameManager.SetGoal(true);
                m_text.gameObject.SetActive(true);
            }
        }
    }
}
