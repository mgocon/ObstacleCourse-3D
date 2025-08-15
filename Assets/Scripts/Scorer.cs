using UnityEngine;

public class Scorer : MonoBehaviour
{
    int hits = 0;

    void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Collision detected with: " + collision.gameObject.name + " (Tag: " + collision.gameObject.tag + ")");
        
        if (collision.gameObject.CompareTag("Obstacle"))
        {
            hits++;
            Debug.Log("Bumps: " + hits);
        }
    }
}
