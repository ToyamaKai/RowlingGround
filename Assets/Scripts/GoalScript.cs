using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GoalScript : MonoBehaviour
{
    private enum GoalType
    {
        Normal,
        Kakushi
    }

    [SerializeField]
    private GameManager m_gameManager;

    [SerializeField]
    GoalType m_goalType;

    [SerializeField]
    private Text        m_text;
<<<<<<< HEAD
=======

>>>>>>> BaseSystem/Timer
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            if (!m_gameManager.GetGoal())
            {
<<<<<<< HEAD
                Debug.Log("Goal");
=======
                m_gameManager.SetGoal(true);
>>>>>>> BaseSystem/Timer
                m_text.gameObject.SetActive(true);
                StartCoroutine("ReturnTitle");
            }
        }
    }
<<<<<<< HEAD

=======
>>>>>>> BaseSystem/Timer
    IEnumerator ReturnTitle()
    {
        yield return new WaitForSeconds(3);
        SceneManager.LoadScene("TitleScene");
    }
}
