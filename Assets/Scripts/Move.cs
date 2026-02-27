using UnityEngine;

public class Move : MonoBehaviour
{
    public float speed = 2f;
    public float leftLimit = -6f;

    void Update()
    {
        transform.position += Vector3.left * speed * Time.deltaTime;

        if (transform.position.x < leftLimit)
        {
            Destroy(gameObject);
        }
    }
}