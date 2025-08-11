using UnityEngine;

public class Scorer : MonoBehaviour
{
    int hits;
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Obstacle"))
        {
            hits++;
            Debug.Log("Bumps: " + hits);
        }
    }
}
