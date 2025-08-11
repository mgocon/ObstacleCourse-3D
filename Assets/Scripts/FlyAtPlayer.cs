using UnityEngine;

public class FlyAtPlayer : MonoBehaviour
{
    [SerializeField] float speed = 5f;
    [SerializeField] float destroyDistance = 0.5f; // Increased threshold
    Transform player;

    void Awake()
    {
        gameObject.SetActive(false);
    }
    void Start()
    {
        // Find the player by tag
        GameObject playerObj = GameObject.FindGameObjectWithTag("Player");
        if (playerObj != null)
        {
            player = playerObj.transform;
        }
    }

    void Update()
    {
        if (player != null)
        {
            MoveToPlayer();
        }
    }

    void MoveToPlayer()
    {
        transform.position = Vector3.MoveTowards(transform.position, player.position, speed * Time.deltaTime);

        // Optional: Destroy when reaching the player
        if (Vector3.Distance(transform.position, player.position) < destroyDistance)
        {
            Destroy(gameObject);
        }
    }
}
