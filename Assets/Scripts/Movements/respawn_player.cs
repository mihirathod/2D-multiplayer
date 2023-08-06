using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class respawn_player : MonoBehaviour
{

    public Transform player;
    public Healthmanager manager;


    private void Update()
    {
        if (manager.currenthealth == 0)
        {
            StartCoroutine(Respawn());
        }
    }

    IEnumerator Respawn()
    {

            yield return new WaitForSeconds(2);
            player.position = new Vector3(10, 05, 0);
            player.rotation = Quaternion.identity;
            manager.currenthealth = manager.maxhealth;




    }
}

