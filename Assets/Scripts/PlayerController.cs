using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController: MonoBehaviour
{
   /* InputHandler input;

    InputHandler input;

    public float airDrag;
    public float groundDrag;

    public float fwdSpeed;
    public float revSpeed;
    public float turnSpeed;
    public LayerMask groundLayer;

    public float speed = 10;

    private float originalSpeed = 10;
    private float boostSpeed = 20;

    public int score = 0;

    //Nitro bar values
    public float maxNitro = 100;
    public float currentNitro;
    public NitroBar Nitro;
    public int minNitro = 0;


    //health bar values
    public int maxHealth = 5;
    public int currentHealth;
    public HealthBar health;


    
    void Start()
    {
 
        rb = GetComponent<Rigidbody>();
        input = InputHandler.instance;

        currentNitro = maxNitro;
        Nitro.SetMaxNitro(maxNitro);

        currentHealth = maxHealth;

        
    }

    private void Update()
    {
        //when space bar press, nitro goes down.
        if (input.nitroDown&& currentNitro>minNitro)
        {
            Debug.Log("Nitro down");
            LoseNitro(Time.deltaTime * 60);

           speed = boostSpeed;


        }

        else
        {
            speed = originalSpeed; 
        }
    }



    
   
    //movement of the player
    void FixedUpdate()
    {
        HandleMovement(Time.deltaTime);
    }

    //movement of the player
    void HandleMovement(float delta)
    {
        Vector3 movement = new Vector3(input.move.x, 0, input.move.y);
        rb.AddForce(movement * speed);
    }

    //Method used to lose nitro
    void LoseNitro(float use)
    {
        if (currentNitro>minNitro)
        {
            currentNitro -= use;
            Nitro.SetNitro(currentNitro);
        }

    }


    //when pick up a coin
    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("pickup"))
        {
            Destroy(other.gameObject);
            score++;
            scoreTxt.SetText("Score: " + score);
            
            //nitro goes up
            currentNitro += 20;
            Nitro.SetNitro(currentNitro);
            
        }

        //when hit an obstacle

        if (other.CompareTag("obstacle"))
        {
            //health goes down by 1
            TakeDamage(1);
            
            Debug.Log("we hit something");
            
           
        }
    }

    //method used to take damage
void TakeDamage(int damage) {

        currentHealth -= damage;
        health.Sethealth(currentHealth);
    }
    


}
