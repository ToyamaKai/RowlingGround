using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeshRendererSwitch : MonoBehaviour
{
    private enum Direction
    {
        Floor,
        Side,
        Front,
    }

    private GameObject[] m_walls;
    private MeshRenderer[] m_wallsMaterial;

    [SerializeField]
    Direction m_direction; //���̃X�N���v�g���A�^�b�`����Ă���I�u�W�F�N�g��Front,Side,Floor�̂ǂꂩ���m�F
    
    [SerializeField]
    GameObject m_player;

    private void Start()
    {
        m_walls = new GameObject[this.transform.childCount];
        m_wallsMaterial = new MeshRenderer[this.transform.childCount];
        GetChilderen();
        SetMaterialAlpha();
    }

    private void Update()
    {
    }

    //�q�I�u�W�F�N�g�̃��b�V�������_���[���擾
    private void GetChilderen()
    {m_walls = new GameObject[this.transform.childCount];
        for(int i = 0; i < this.transform.childCount; i++)
        {
            m_walls[i] = this.transform.GetChild(i).gameObject;
            m_wallsMaterial[i] = m_walls[i].GetComponent<MeshRenderer>();
        }
    }

    //��]���I�������ɕǂ��ǂ��ɂ��邩�̏�����������
    public void ChangeDirection(GameManager.InputGetKey Key)
    {
        if(Key == GameManager.InputGetKey.QKey || Key == GameManager.InputGetKey.EKey)
        {
            if (m_direction == Direction.Side)
            {
                m_direction = Direction.Front;
                SetMaterialAlpha();
                return;
            }
            if (m_direction == Direction.Front)
            {
                m_direction = Direction.Side;
                SetMaterialAlpha();
                return;
            }
        }
        else if(Key == GameManager.InputGetKey.UpKey || Key == GameManager.InputGetKey.DownKey)
        {
            if (m_direction == Direction.Front)
            {
                m_direction = Direction.Floor;
                SetMaterialAlpha();
                return;
            }
            if (m_direction == Direction.Floor)
            {
                m_direction = Direction.Front;
                SetMaterialAlpha();
                return;
            }
        }
        else if (Key == GameManager.InputGetKey.LeftKey || Key == GameManager.InputGetKey.RightKey)
        {
            if (m_direction == Direction.Side)
            {
                m_direction = Direction.Floor;
                SetMaterialAlpha();
                return;
            }
            if (m_direction == Direction.Floor)
            {
                m_direction = Direction.Side;
                SetMaterialAlpha();
                return;
            }
        }
    }

    private void SetMaterialAlpha()
    {
        if (m_direction == Direction.Floor)
        {
            for (int i = 0; i < this.transform.childCount; i++)
            {
                m_wallsMaterial[i].enabled = true;
            }
            return;
        }
        if (m_direction == Direction.Side)
        {
            for (int i = 0; i < this.transform.childCount; i++)
            {
                m_wallsMaterial[i].enabled = true;
            }
            return;
        }
        if(m_direction == Direction.Front)
        {
            for (int i = 0; i < this.transform.childCount; i++)
            {
                if (m_walls[i].transform.position.z <= m_player.transform.position.z)
                {
                    m_wallsMaterial[i].enabled = false;
                }
            }
            return;
        }
    }
}