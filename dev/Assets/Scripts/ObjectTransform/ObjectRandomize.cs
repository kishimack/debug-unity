using UnityEngine;

public class ObjectRandomize: MonoBehaviour
{
    void Awake()
    {
        gameObject.AddComponent<ObjectRandomize>();

        transform.Translate(
            Random.Range(-2.0f, 2.0f),
            Random.Range(-2.0f, 2.0f),
            Random.Range(-2.0f, 2.0f));
        transform.Rotate(
            Random.Range(0.0f, 360.0f),
            Random.Range(0.0f, 360.0f),
            Random.Range(0.0f, 360.0f));
        transform.localScale = new Vector3(
            Random.Range(0.5f, 1.0f),
            Random.Range(0.5f, 1.0f),
            Random.Range(0.5f, 1.0f));
    }
}
