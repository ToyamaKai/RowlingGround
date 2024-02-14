using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuButtonManager : MonoBehaviour
{
    [SerializeField]
    GameObject m_menu;

    [SerializeField]
    GameObject m_explanation;

    private bool isMenu;
    private bool isReturnToTitle;
    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1;
        m_menu.SetActive(false);
        m_explanation.SetActive(false);
        isMenu = false;
        isReturnToTitle = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            if (!isMenu)
            {
                Time.timeScale = 0;
                isMenu = true;
                m_explanation.SetActive(false);
                m_menu.SetActive(true);
            }
            else
            {
                Time.timeScale = 1;
                isMenu = false;
                m_menu.SetActive(false);
            }
        }
    }

    public void Retry()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void Explanation()
    {
        m_explanation.SetActive(true);
    }

    public void ReturnToTile ()
    {
        if(!isReturnToTitle)
        {
            isReturnToTitle = true;
            SceneManager.LoadScene("TitleScene");
        }
    }

    public void ExitExplanation()
    {
        m_explanation.SetActive(false);
    }
}
