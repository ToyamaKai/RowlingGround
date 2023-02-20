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

    [SerializeField] Direction m_direction;
    [SerializeField] GameObject m_player;

    private void Start()
    {
        m_walls = new GameObject[this.transform.childCount];
        m_wallsMaterial = new MeshRenderer[this.transform.childCount];
        GetChilderen();
    }

    private void Update()
    {
    }
    private void GetChilderen()
    {m_walls = new GameObject[this.transform.childCount];
        for(int i = 0; i < this.transform.childCount; i++)
        {
            m_walls[i] = this.transform.GetChild(i).gameObject;
            m_wallsMaterial[i] = m_walls[i].GetComponent<MeshRenderer>();
        }
    }
    public void ChangeDirection()
    {
        if(m_direction == Direction.Side)
        {
            m_direction = Direction.Front;
            SetMaterialAlpha();
            return;
        }
        if(m_direction == Direction.Front)
        {
            m_direction = Direction.Side;
            SetMaterialAlpha();
            return;
        }
    }

    private void SetMaterialAlpha()
    {
        if (m_direction == Direction.Side)
        {
            for (int i = 0; i < this.transform.childCount; i++)
            {
                m_wallsMaterial[i].material.color = new Color(m_wallsMaterial[i].material.color.r, m_wallsMaterial[i].material.color.g, m_wallsMaterial[i].material.color.b, 1);
            }
            return;
        }
        if(m_direction == Direction.Front)
        {
            for (int i = 0; i < this.transform.childCount; i++)
            {
                if (m_walls[i].transform.position.z < m_player.transform.position.z)
                {
                    m_wallsMaterial[i].material.color = new Color(m_wallsMaterial[i].material.color.r, m_wallsMaterial[i].material.color.g, m_wallsMaterial[i].material.color.b, 0);
                }
            }
            return;
        }
    }
}
