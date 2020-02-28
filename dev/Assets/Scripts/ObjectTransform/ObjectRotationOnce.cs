using UnityEngine;

public class ObjectRotationOnce : MonoBehaviour
{
    private float m_Angle;
    
    void Awake()
    {
        m_Angle = Random.Range(0.0f, 360.0f);
        transform.Rotate(0.0f, m_Angle, 0.0f);
    }
}
