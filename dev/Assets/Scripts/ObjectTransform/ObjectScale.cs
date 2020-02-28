using UnityEngine;

public class ObjectScale : MonoBehaviour
{
    private float m_Scale;
    public float Scale
    {
        set
        {
            m_Scale = value;
            transform.localScale = Vector3.one * m_Scale;
        }
    }
    
    void Awake()
    {
        m_Scale = 1.0f;
    }
}
