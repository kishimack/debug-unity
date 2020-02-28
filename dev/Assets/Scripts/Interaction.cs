using UnityEngine;

public class Interaction : MonoBehaviour
{
    [SerializeField]
    private TypeEnum m_Type;

    [SerializeField]
    private GameObject m_Prefab;

    private int m_PrimitiveCount;

    void Awake()
    {
        m_PrimitiveCount = 0;
    }

    void Update()
    {
        if (m_Type == TypeEnum.AnotherValue)
        {
            if (Input.GetKeyDown(KeyCode.Q))
            {
                new CubeCreator(m_PrimitiveCount);
                ++m_PrimitiveCount;
            }
            else if (Input.GetKeyDown(KeyCode.W))
            {
                new SphereCreator(m_PrimitiveCount);
                ++m_PrimitiveCount;
            }
            else if (Input.GetKeyDown(KeyCode.E))
            {
                new PlaneCreator(m_PrimitiveCount);
                ++m_PrimitiveCount;
            }
            else if (Input.GetKeyDown(KeyCode.R))
            {
                new PrefabCreator(m_PrimitiveCount, m_Prefab);
                ++m_PrimitiveCount;
            }
        }
    }
}
