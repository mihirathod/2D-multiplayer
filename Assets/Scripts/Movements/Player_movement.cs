using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;


public class Player_movement : MonoBehaviour
{
    public Vector2 MoveInput;
    public Healthmanager manager;


   

    public void OnMove(InputValue input)
    {
        if (manager.currenthealth >0)
        {
            MoveInput = input.Get<Vector2>();

        }
    }


}
