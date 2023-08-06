using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Healthmanager : MonoBehaviour
{
    public int maxhealth = 100;
    public int currenthealth;
    public Slider healthbar;
    public AudioSource damagesound;


    public void Start()
    {
        currenthealth = maxhealth;
        damagesound.GetComponent<AudioSource>();
    }
    private void Update()
    {
        healthbar.value = currenthealth;
        if (currenthealth < 0)
        {
            currenthealth = 0;
        }
    }
    public void Damager(int damage)
    {
        currenthealth -= damage;
        damagesound.Play();
           
    }
    public void Heal(int damage)
    {
        currenthealth += damage;
        if (currenthealth > 0)
        {
            currenthealth = maxhealth;


        }
    }

}
