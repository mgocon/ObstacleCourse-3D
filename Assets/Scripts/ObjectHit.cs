using UnityEngine;

public class ObjectHit : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Debug.Log("Ouch you’ve hit me!");
            GetComponent<Renderer>().material.color = Color.red;
            gameObject.tag = "Hit"; // Assign the "Hit" tag after being hit
        }
    }
}
