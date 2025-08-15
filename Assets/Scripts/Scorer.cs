using UnityEngine;

public class Scorer : MonoBehaviour
{
    int hits = 0;

    void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Ouch you've hit me!");
        
        if (collision.gameObject.CompareTag("Obstacle"))
        {
            hits++;
            Debug.Log("Bumps: " + hits);
        }
    }
}
