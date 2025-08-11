using UnityEngine;

public class Spinner : MonoBehaviour
{
    [SerializeField] float spinSpeed = 5f;
    [SerializeField] float xAngle;
    [SerializeField] float yAngle;
    [SerializeField] float zAngle;

    void Update()
    {
        // Spin the object around its local axes
        transform.Rotate(xAngle * spinSpeed * Time.deltaTime, 
                         yAngle * spinSpeed * Time.deltaTime, 
                         zAngle * spinSpeed * Time.deltaTime);
    }
}
