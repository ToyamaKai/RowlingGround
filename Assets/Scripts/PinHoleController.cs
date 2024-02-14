using UnityEngine;

public class PinHoleController : MonoBehaviour
{
    [SerializeField] GameObject nyan;
    [SerializeField] GameObject player;

    void Update()
    {
		var pinPos = new Vector4(Input.mousePosition.x / Screen.width, Input.mousePosition.y / Screen.height, 0f);
		nyan.GetComponent<Renderer>().material.SetVector("_HolePos", pinPos);
    }
}