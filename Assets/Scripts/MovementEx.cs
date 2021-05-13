using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class MovementEx : MonoBehaviour
{
    InputHandler input;
    public float maxNitro = 100;
    public float currentNitro;

    public NitroBar Nitro;


    private Rigidbody rb;

    public TMP_Text scoreTxt;

    public float speed = 5;

    public int score = 0;

    // Start is called before the first frame update
    void Start()
    {
        input = InputHandler.instance;
        currentNitro = maxNitro;
        Nitro.SetMaxNitro(maxNitro);
        
    }

    // Update is called once per frame
    void Update()
    {

        


        if (input.nitroDown)
        {
            Debug.Log("Nitro down");
            LoseNitro(Time.deltaTime * 60); 
        } else if(CompareTag("pickup") && currentNitro < maxNitro)
        {
            currentNitro += Time.deltaTime * 20;
            Nitro.SetNitro(currentNitro);
        }
    }

    
 

    void LoseNitro(float use)
    {
        currentNitro -= use;
        Nitro.SetNitro(currentNitro);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("pickup"))
        {
            Destroy(other.gameObject);
            score++;
            scoreTxt.SetText("Score: " + score);
            if (score >= 11)
            {
                scoreTxt.SetText("You Won!");
            }
        }
    }
}
