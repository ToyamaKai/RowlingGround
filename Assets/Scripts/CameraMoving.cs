using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMoving : MonoBehaviour
{
    private Vector3 position;
    private Vector3 playerPosition;

    [SerializeField]
    private GameObject playerObject;
    // Start is called before the first frame update
    void Start()
    {
        position = this.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        playerPosition = playerObject.transform.position;
        position.x = playerPosition.x;
        position.y = playerPosition.y + 0.5f;
        position.z = playerPosition.z - 5.0f;
        this.transform.position = position;
    }
}
