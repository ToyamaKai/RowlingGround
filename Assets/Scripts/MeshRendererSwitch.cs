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

    [SerializeField] Direction m_direction;

    public void ChangeDirection()
    {
        if(m_direction == Direction.Side) { m_direction = Direction.Front; }
        if(m_direction == Direction.Front) { m_direction = Direction.Side; }
    }
}
