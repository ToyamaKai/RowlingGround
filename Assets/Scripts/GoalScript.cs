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
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            if (!m_gameManager.GetGoal())
            {
                m_gameManager.SetGoal(true);
                m_text.gameObject.SetActive(true);
                StartCoroutine("ReturnTitle");
            }
        }
    }
    IEnumerator ReturnTitle()
    {
        yield return new WaitForSeconds(3);
        SceneManager.LoadScene("TitleScene");
    }
}
