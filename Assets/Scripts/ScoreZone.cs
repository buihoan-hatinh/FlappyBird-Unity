using UnityEngine;

public class ScoreZone : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("TRIGGER WORKED");

        if (collision.CompareTag("Player"))
        {
            Debug.Log("ADD SCORE");
            FindObjectOfType<GameManager>().AddScore();
        }
    }
}   