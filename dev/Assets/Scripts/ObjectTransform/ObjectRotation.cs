using UnityEngine;

public class ObjectRotation : MonoBehaviour
{
    private float m_Angle;
    
    void Awake()
    {
        m_Angle = Mathf.Deg2Rad * 5.0f;
    }

    void Update()
    {
        transform.Rotate(0.0f, m_Angle, 0.0f);
    }
}
