using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeshRendererSwitch : MonoBehaviour
{
    MeshRenderer mesh;

    private void Start()
    {
        mesh = GetComponent<MeshRenderer>();
    }

    public IEnumerator Transparent()
    {
        for(int i = 0; i < 85; i++)
        {
            mesh.material.color = mesh.material.color - new Color32(0, 0, 0, 3);
            yield return new WaitForSeconds(0.01f);
        }
    }
}
