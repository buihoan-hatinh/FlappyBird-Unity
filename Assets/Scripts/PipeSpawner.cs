using UnityEngine;

public class PipeSpawner : MonoBehaviour
{
    public GameObject pipePrefab;
    public float spawnRate = 2f;

    void Start()
    {
        InvokeRepeating(nameof(SpawnPipe), 1f, spawnRate);
    }

    void SpawnPipe()
    {
        if (pipePrefab == null)
        {
            Debug.LogError("Pipe Prefab chưa gán!");
            return;
        }

        Instantiate(pipePrefab, transform.position, Quaternion.identity);
    }
}