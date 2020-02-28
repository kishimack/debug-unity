using UnityEngine;

public class CubeCreator : PrimitiveCreator
{
    public CubeCreator(int number) : base(number)
    {
    }

    public override void Create(int number)
    {
        GameObject go = GameObject.CreatePrimitive(PrimitiveType.Cube);
        go.name = $"Cube_{number}";

        ObjectTranslation t = go.AddComponent<ObjectTranslation>();
        t.Set(Random.Range(-2.0f, 2.0f),
            Random.Range(-2.0f, 2.0f),
            Random.Range(-2.0f, 2.0f));

        go.AddComponent<ObjectRotation>();
    }
}
