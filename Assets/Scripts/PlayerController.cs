using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController: MonoBehaviour
{
    private float moveInput;
    private float turnInput;

    public float fwdSpeed;
    public float revSpeed;
    public float turnSpeed;

    public Rigidbody sphereRB;



    void Start()
    {
        sphereRB.transform.parent = null;

    }

    void Update()
    {
        moveInput = Input.GetAxisRaw("Vertical");
        turnInput - Input.GetAxisRaw("Horizontal");
        moveInput *= fwdSpeed > 0 ? fwdSpeed : revSpeed;

        transform.position = sphereRB.transform.position;



    }
    private void FixedUpdate()
    {
        sphereRB.AddForce(transform.forward * moveInput, ForceMode.Acceleration);
    }

}
