using System.Collections;
using System.Collections.Generic;
using UnityEngine;
<<<<<<< Updated upstream
<<<<<<< Updated upstream

public class GoalScript : MonoBehaviour
{
    [SerializeField] private GameManager m_gameManager;
=======
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GoalScript : MonoBehaviour
{
=======
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GoalScript : MonoBehaviour
{
>>>>>>> Stashed changes
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

>>>>>>> Stashed changes
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            if(!m_gameManager.GetGoal())
            {
                m_gameManager.SetGoal(true);
<<<<<<< Updated upstream
                Debug.Log("Goal");
=======
                m_text.gameObject.SetActive(true);
                StartCoroutine("ReturnTitle");
<<<<<<< Updated upstream
>>>>>>> Stashed changes
=======
>>>>>>> Stashed changes
            }
        }
    }
    IEnumerator ReturnTitle()
    {
        yield return new WaitForSeconds(3);
        SceneManager.LoadScene("TitleScene");
    }
}
