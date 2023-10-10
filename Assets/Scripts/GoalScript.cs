using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalScript : MonoBehaviour
{
    [SerializeField] private GameManager m_gameManager;
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            if(!m_gameManager.GetGoal())
            {
                m_gameManager.SetGoal(true);
                Debug.Log("Goal");
            }
        }
    }
}
