using UnityEngine;

public class SimpleNoise : MonoBehaviour
{
    public float Amplitude = .15f;
    public float Frequency = .5f;

    void Update()
    {
        var x = (Mathf.PerlinNoise(420, Time.time * Frequency) - .5f) * Amplitude;
        var y = (Mathf.PerlinNoise(69, Time.time * Frequency) - .5f) * Amplitude;
        var z = (Mathf.PerlinNoise(0, Time.time * Frequency) - .5f) * Amplitude;

        transform.localPosition = new Vector3(x, y, z / 5f);
    }
}
