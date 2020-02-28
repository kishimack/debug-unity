using UnityEngine;

public class PrefabCreator : PrimitiveCreator
{
    private GameObject m_Prefab;

    public PrefabCreator(int number, GameObject prefab) : base(number)
    {
        m_Prefab = prefab;
    }

    public override void Create(int number)
    {
        GameObject go = GameObject.Instantiate(m_Prefab);
        go.name = $"Prefab_{number}";
    }
}
