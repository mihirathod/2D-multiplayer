using System;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class Movement : MonoBehaviour
{
    private Player_movement inputs;
    private Rigidbody2D rb;
    private Animator animator;
    public float Speed;
    Vector2 moveDir;
    bool isMoving;
    public GameObject leftparticle;
    public GameObject leftparticle2;
    private Healthmanager manager;
    public GameObject[] guns;
    public Transform player;
   

    void Awake()
    {
        inputs = GetComponent<Player_movement>();
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
         manager = GetComponent<Healthmanager>();

    }

    void Update()
    {
        moveDir = inputs.MoveInput.normalized;
        if (!isMoving)
        {
            player.rotation =  Quaternion.identity;
        }
        else if (!isMoving)
        {
            player.rotation =  Quaternion.identity;
        }
       

        isMoving = Convert.ToBoolean(moveDir.magnitude);
        Rotate();
        particlesys();
        if (manager.currenthealth == 0)
        {
            guns[0].SetActive(false);
            guns[1].SetActive(false);
            guns[2].SetActive(false);
            guns[3].SetActive(false);
           
        }
    }

    private void FixedUpdate()
    {
        Onanimation();


        if (rb != null)
        {
            rb.MovePosition(rb.position + moveDir * Speed * Time.fixedDeltaTime);
        }
    }

    void Rotate()
    {
        if (isMoving)
        {
            float angle = Mathf.Atan2(moveDir.y, moveDir.x) * Mathf.Rad2Deg - 90f; 
            
            transform.rotation = Quaternion.Euler(0, 0, angle/12);
        }
        

    }

    void Onanimation()
    {
        if (isMoving)
        {
            animator.SetBool("Walk", true);
        }
        else
        {
            animator.SetBool("Walk", false);

        }

    }
      void particlesys()
    {
        if (isMoving)
        {
            leftparticle.SetActive(true);

            leftparticle2.SetActive(true);
        }
        else
        {
            leftparticle.SetActive(false);
            leftparticle2.SetActive(false);


        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("1"))
        {

            guns[0].gameObject.SetActive(true);
            guns[1].gameObject.SetActive(false);
            guns[2].gameObject.SetActive(false);
            guns[3].gameObject.SetActive(false);

        }
        if (other.CompareTag("2"))
        {
            guns[0].gameObject.SetActive(false);
            guns[1].gameObject.SetActive(true);
            guns[2].gameObject.SetActive(false);
            guns[3].gameObject.SetActive(false);
        }
        if (other.CompareTag("3"))
        {
            guns[0].gameObject.SetActive(false);
            guns[1].gameObject.SetActive(false);
            guns[2].gameObject.SetActive(true);
            guns[3].gameObject.SetActive(false);
        }
        if (other.CompareTag("4"))
        {
            guns[0].gameObject.SetActive(false);
            guns[1].gameObject.SetActive(false);
            guns[2].gameObject.SetActive(false);
            guns[3].gameObject.SetActive(true);
        }
    }
       
        
    

    
}
