using UnityEngine;

public class ObjectTranslation : MonoBehaviour
{
    private Vector3 m_Position;
    public Vector3 Position
    {
        set
        {
            Set(value.x, value.y, value.z);
        }
    }

    public void Set(float x, float y, float z)
    {
        m_Position.x = x;
        m_Position.y = y;
        m_Position.z = z;
        transform.position = m_Position;
    }
}
