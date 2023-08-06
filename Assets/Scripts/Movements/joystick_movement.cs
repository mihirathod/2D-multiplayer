using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class joystick_movement : MonoBehaviour
{
    //Right Joystick
    public Joystick joystick;
    float hormove;
    public Transform firingpt;
    public bool Onfiring;
    [SerializeField] Transform Player;
    private float changevalue = 10f;
    [SerializeField] private Healthmanager manager;
     [SerializeField]  private float rotatingangl;
    //public bool hormoved;
    public void Update()
    {

        hormove = joystick.Horizontal * changevalue;
        float vermove = joystick.Vertical * changevalue;

        


            if (hormove < 0)
            {
                Player.transform.localScale = new Vector3(-0.3f, 0.2f, 1);
                gameObject.transform.localRotation = Quaternion.Euler(0, 0, vermove *rotatingangl);
                firingpt.transform.localRotation = Quaternion.Euler(0, -180, 0);
            }
            if (hormove > 0)
            {
                Player.transform.localScale = new Vector3(0.3f, 0.2f, 1);
                gameObject.transform.localRotation = Quaternion.Euler(0, 0, vermove *rotatingangl);
                firingpt.transform.localRotation = Quaternion.Euler(0, 0, 0);
            }
            if (hormove > 0f || vermove > 0f || hormove < 0f || vermove < 0f)
            {
                Onfiring = true;
            }
            else
            {
                Onfiring = false;
            }
        


    }
    
    
}
