using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class sceneTransition : MonoBehaviour
{
    private bool m_isTransition;
    
    void Start()
    {
        m_isTransition = false;
    }

    public void OnClick()
    {
        if(!m_isTransition)
        {
            SceneManager.LoadScene("RowlingGround");
            m_isTransition = true;
        }
    }
}
