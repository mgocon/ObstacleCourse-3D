using UnityEngine;

public class TriggerProjectile : MonoBehaviour
{
    [SerializeField] GameObject projectile1;
    [SerializeField] GameObject projectile2;
    [SerializeField] GameObject projectile3;
    [SerializeField] GameObject projectile4;
    [SerializeField] GameObject projectile5;
    [SerializeField] GameObject projectile6;
    [SerializeField] GameObject projectile7;
    [SerializeField] GameObject projectile8;

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            //*Uncomment projectiles if you want to add more
            projectile1.SetActive(true);
            projectile2.SetActive(true);
            projectile3.SetActive(true);
            // projectile4.SetActive(true);
            // projectile5.SetActive(true);
            // projectile6.SetActive(true);
            // projectile7.SetActive(true);
            // projectile8.SetActive(true);
        }
    }   
}
