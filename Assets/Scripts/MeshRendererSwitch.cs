using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeshRendererSwitch : MonoBehaviour
{
    private enum Direction
    {
        Side,
        Front,
    }

    private GameObject[] m_walls;
    private MeshRenderer[] m_wallsMaterial;
    private Color[] m_wallColors;

    [SerializeField] Direction m_direction;

    private void Start()
    {
        m_walls = new GameObject[this.transform.childCount];
        m_wallsMaterial = new MeshRenderer[this.transform.childCount];
        m_wallColors = new Color[this.transform.childCount];
        GetChilderen();
    }

    private void Update()
    {
        SetMaterialAlpha();
    }
    private void GetChilderen()
    {m_walls = new GameObject[this.transform.childCount];
        for(int i = 0; i < this.transform.childCount; i++)
        {
            m_walls[i] = this.transform.GetChild(i).gameObject;
            m_wallsMaterial[i] = m_walls[i].GetComponent<MeshRenderer>();
            m_wallColors[i] = m_wallsMaterial[i].material.color;
        }
    }
    public void ChangeDirection()
    {
        if(m_direction == Direction.Side)
        {
            m_direction = Direction.Front;
            return;
        }
        if(m_direction == Direction.Front)
        {
            m_direction = Direction.Side;
            return;
        }
    }

    private void SetMaterialAlpha()
    {
        if (m_direction == Direction.Side)
        {
            for (int i = 0; i < this.transform.childCount; i++)
            {
            }
            return;
        }
        if(m_direction == Direction.Front)
        {
            for (int i = 0; i < this.transform.childCount; i++)
            {
            }
            return;
        }
    }
}
