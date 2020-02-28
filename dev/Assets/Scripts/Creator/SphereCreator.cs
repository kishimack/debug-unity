using UnityEngine;

public class SphereCreator : PrimitiveCreator
{
    public SphereCreator(int number) : base()
    {
    }

    public override void Create(int number)
    {
        GameObject go = GameObject.CreatePrimitive(PrimitiveType.Sphere);
        go.name = $"Sphere_{number}";

        ObjectTranslation t = go.AddComponent<ObjectTranslation>();
        t.Set(Random.Range(-2.0f, 2.0f),
            Random.Range(-2.0f, 2.0f),
            Random.Range(-2.0f, 2.0f));
        
        ObjectScale scale = go.AddComponent<ObjectScale>();
        scale.Scale = Random.Range(0.5f, 1.5f);
    }
}
