using UnityEngine;

public class ObjectHit : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            // First let other scripts handle the collision
            StartCoroutine(ChangeAfterDelay());
        }
    }

    private System.Collections.IEnumerator ChangeAfterDelay()
    {
        // Wait for end of frame to change appearance and tag
        yield return new WaitForEndOfFrame();
        GetComponent<Renderer>().material.color = Color.red;
        gameObject.tag = "Hit";
        Debug.Log("Object hit and changed to red!");
    }
}
