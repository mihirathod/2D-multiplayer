using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bulletscript : MonoBehaviour
{
    [SerializeField] Rigidbody2D bulletrb;
    [SerializeField]  float speed;
    [SerializeField] int damaged;

    private void Start()
    {
        bulletrb.velocity = transform.right * speed;

    }
   

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            var healthcomponent = collision.GetComponent<Healthmanager>();
            if (healthcomponent != null)
            {
                healthcomponent.Damager(damaged);
            }
        }

        Destroy(this.gameObject);
    }
}
