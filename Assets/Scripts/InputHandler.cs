using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputHandler : MonoBehaviour
{
    public static InputHandler instance;

    private Controls controls;

    public Vector2 move;
    public Vector2 look;


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
    }

    private void OnEnable()
    {
        controls.Enable();
    }

    private void OnDisable()
    {
        controls.Disable();
    }

    void Start()
    {
        controls.Movement.Move.performed += controls => move = controls.ReadValue<Vector2>();
        controls.Movement.Look.performed += controls => look = controls.ReadValue<Vector2>();

    }

}
