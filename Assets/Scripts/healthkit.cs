using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class healthkit : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            var healthcomponent = collision.GetComponent<Healthmanager>();
            if (healthcomponent != null)
            {
                healthcomponent.Heal(100);
            }
        }

        Destroy(this.gameObject);
    }
}
