using UnityEngine;

public class Dropper : MonoBehaviour
{
    public float dropDelay = 3f;

    Renderer rend;
    Rigidbody rb;

    void Start()
    {
        rend = GetComponent<Renderer>();
        rb = GetComponent<Rigidbody>();
        if (rend) rend.enabled = false; // invisible at start
        if (rb) rb.useGravity = false;  // don’t fall yet
    }

    void Update()
    {
        if (Time.time >= dropDelay)
        {
            if (rend) rend.enabled = true; // show and cast shadow
            if (rb) rb.useGravity = true;  // start falling
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player") && rend)
        {
            rend.material.color = Color.red;
        }
    }
}