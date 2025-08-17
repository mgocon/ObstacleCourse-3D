using UnityEngine;

public class FlyAtPlayer : MonoBehaviour
{
    [SerializeField] Transform target; // assign Player here or via tag fallback
    [SerializeField] float speed = 5f;
    [SerializeField] float reachDistance = 0.1f;
    [SerializeField] bool destroyOnReach = true;

    void Awake()
    {
        gameObject.SetActive(false); //?Game object is always set to false on start
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        if (target == null)
        {
            var player = GameObject.FindGameObjectWithTag("Player");
            if (player) target = player.transform;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (target == null) return;

        // Move towards the player's position
        transform.position = Vector3.MoveTowards(
            transform.position,
            target.position,
            speed * Time.deltaTime
        );

        // Optionally destroy when it reaches the player
        if (destroyOnReach && Vector3.Distance(transform.position, target.position) <= reachDistance)
        {
            Destroy(gameObject);
        }
    }

    // Destroy on non-trigger collision with the Player
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Destroy(gameObject);
        }
    }
}
