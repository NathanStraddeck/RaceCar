using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController: MonoBehaviour
{
    InputHandler input;

    private float moveInput;
    private float turnInput;
    private bool isCarGrounded;

    public float airDrag;
    public float groundDrag;

    public float fwdSpeed;
    public float revSpeed;
    public float turnSpeed;
    public LayerMask groundLayer;

    public Rigidbody sphereRB;



    void Start()
    {
        sphereRB.transform.parent = null;
        input = InputHandler.instance;
    }

    void Update()
    {
        moveInput = input.move.y;
        turnInput = input.move.x;

        moveInput *= fwdSpeed > 0 ? fwdSpeed : revSpeed;

        transform.position = sphereRB.transform.position;

        float newRotation = turnInput * turnSpeed * Time.deltaTime * input.move.y;
        transform.Rotate(0, newRotation, 0, Space.World);

        RaycastHit hit;
        isCarGrounded = Physics.Raycast(transform.position, -transform.up, out hit, 1f, groundLayer);

        transform.rotation = Quaternion.FromToRotation(transform.up, hit.normal) * transform.rotation;

        if (isCarGrounded)
        {
            sphereRB.drag = groundDrag;
        }
        else
        {
            sphereRB.drag = airDrag;
        }
    }
    private void FixedUpdate()
    {
       
        if (isCarGrounded)
        {
            sphereRB.AddForce(transform.forward * moveInput, ForceMode.Acceleration);
        }
        else
        {
            sphereRB.AddForce(transform.up * -40f);
        }
    }

}
