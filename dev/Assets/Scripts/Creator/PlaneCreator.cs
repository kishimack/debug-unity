using UnityEngine;

public class PlaneCreator : PrimitiveCreator
{
    public PlaneCreator(int number) : base(number)
    {
    }

    public override void Create(int number)
    {
        GameObject go = GameObject.CreatePrimitive(PrimitiveType.Plane);
        go.name = $"Plane_{number}";

        ObjectTranslation t = go.AddComponent<ObjectTranslation>();
        t.Set(Random.Range(-2.0f, 2.0f),
            Random.Range(-2.0f, 2.0f),
            Random.Range(-2.0f, 2.0f));

        ObjectScale scale = go.AddComponent<ObjectScale>();
        scale.Scale = Random.Range(0.5f, 1.0f);

        go.AddComponent<ObjectRotationOnce>();
    }
}
