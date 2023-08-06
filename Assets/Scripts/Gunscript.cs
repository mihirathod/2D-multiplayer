using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gunscript : MonoBehaviour
{
    [SerializeField] Transform firingpts;
    public GameObject bulletPrefab;
    [SerializeField] private joystick_movement rightmovement;
    [SerializeField] float firing_speed;
    [SerializeField] int magzinesize;
    [SerializeField] int currentbullet;
    [SerializeField] float reloadtime;
    public AudioSource Bulletaudio;
    private void Awake()
    {
        StartCoroutine(Firing());
        currentbullet = magzinesize;
        Bulletaudio.GetComponent<AudioSource>();

    }

    void spawnbullets()
    {
        

        if (currentbullet <=0)
        {
            StartCoroutine(Reload());
            return;
        }
        if (rightmovement.Onfiring == true)
        {
            GameObject Bullet = Instantiate(bulletPrefab, firingpts.position, firingpts.rotation);
            Bulletaudio.Play();
            currentbullet--;
        }

    }

   
    IEnumerator Firing()
    {
        while (true)
        {

            yield return new WaitForSeconds(firing_speed);
            spawnbullets();
        }


    }
    IEnumerator Reload()
    {
        yield return new WaitForSeconds(reloadtime);
        currentbullet = magzinesize;
    }
}
