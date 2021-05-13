using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputHandler : MonoBehaviour
{
    Controls controls;

    public Vector2 move;

    public static InputHandler instance;

    public bool nitroDown = false;

    private void Awake()
    {
        if (instance != null)
        {
            Destroy(this);

        }
        else
        {
            instance = this;
        }

        controls = new Controls();
        controls.Enable();
    }

    private void OnDisable()
    {
        controls.Disable();
    }

    void Start()
    {
        //arguement => whatever logic you want to execute
        controls.Movement.Move.performed += controls => move = controls.ReadValue<Vector2>();

        controls.Nitro.UseNitro.performed += controls =>
        {
            Debug.Log("nitro detected");
            nitroDown = true;
        };
        controls.Nitro.UseNitro.canceled += controls => nitroDown = false;
    }



}
