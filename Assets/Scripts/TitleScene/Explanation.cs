using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explanation : MonoBehaviour
{
    [SerializeField]
    GameObject m_explanation;
    // Start is called before the first frame update
    void Start()
    {
        m_explanation.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SetActive()
    {
        Debug.Log("‚È‚ñ‚Å");
        m_explanation.SetActive(true);
    }

    public void Kakusu()
    {
        m_explanation.SetActive(false);
    }
}
