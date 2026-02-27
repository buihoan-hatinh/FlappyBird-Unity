using UnityEngine;

public class Pipe : MonoBehaviour
{
    public Transform pipeUp;
    public Transform pipeDown;

    public float gap = 3f;
    public float minY = -2f;
    public float maxY = 2f;

    void Start()
    {
        float randomY = Random.Range(minY, maxY);
        transform.position = new Vector3(
            transform.position.x,
            randomY,
            transform.position.z
        );
    }
}