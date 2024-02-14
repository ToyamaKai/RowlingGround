using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class Raycast : MonoBehaviour
{
    [SerializeField]
    private Transform m_player; //”íŽÊ‘Ì

    [SerializeField]
    private List<string> m_coverLayerNameList; //ŽÕ•Á•¨–¼

    private int m_layerMask;

    public List<Renderer>   m_rendererHitsList = new List<Renderer>();
    public Renderer[]       m_rendererHitsPrevs;

    // Start is called before the first frame update
    void Start()
    {
        m_layerMask = 0;
        foreach (string layerName in m_coverLayerNameList)
        {
            m_layerMask |= 1 << LayerMask.NameToLayer(layerName);
        }
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 difference  = (m_player.transform.position - this.transform.position);
        Vector3 direction   = difference.normalized;
        Ray     ray         = new Ray(this.transform.position, direction);

        RaycastHit[] hits = Physics.RaycastAll(ray, difference.magnitude, m_layerMask);

        m_rendererHitsPrevs = m_rendererHitsList.ToArray();
        m_rendererHitsList.Clear();

        foreach(RaycastHit hit in hits)
        {
            if(hit.collider.gameObject == m_player)
            {
                continue;
            }

            Renderer renderer = hit.collider.gameObject.GetComponent<Renderer>();
            if(renderer != null)
            {
                m_rendererHitsList.Add(renderer);
                renderer.enabled = false;
            }
        }

        foreach(Renderer renderer in m_rendererHitsPrevs.Except<Renderer>(m_rendererHitsList))
        {
            if(renderer != null)
            {
                renderer.enabled = true;
            }
        }
    }
}
