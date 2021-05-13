// GENERATED AUTOMATICALLY FROM 'Assets/Scripts/input/Controls.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @Controls : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @Controls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""Controls"",
    ""maps"": [
        {
            ""name"": ""Movement"",
            ""id"": ""ee97aa41-6d5b-4729-8b99-3c1b433e626d"",
            ""actions"": [
                {
                    ""name"": ""Move"",
                    ""type"": ""PassThrough"",
                    ""id"": ""30f190a8-39d6-4800-a519-6d8bb4f9f217"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Look"",
                    ""type"": ""PassThrough"",
                    ""id"": ""7aaeec00-79dc-4ab4-9237-23482f59940e"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Brake"",
                    ""type"": ""Button"",
                    ""id"": ""3a9e933c-a931-434a-8891-7e0ee94b161a"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""WASD"",
                    ""id"": ""6a9e75d1-608d-4256-9100-f269c39188a5"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""1a1facd1-0995-46e2-9e28-73ae1e176494"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""e7bb94d3-c21c-4745-ac77-ea5e758fb0cf"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""9e63815f-91f1-4f16-9db4-4c40d53da935"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""ac8f24f6-6963-4e36-a01f-1cff569addf3"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""37077196-5d16-4a2a-882b-ad434c354084"",
                    ""path"": ""<Mouse>/delta"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Look"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""d7a85fd5-fee5-40b2-ad5a-95f41a7458dd"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Brake"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Nitro"",
            ""id"": ""e5a94b01-55fd-47c7-ba36-04bdef8bf139"",
            ""actions"": [
                {
                    ""name"": ""Use Nitro"",
                    ""type"": ""Button"",
                    ""id"": ""43146889-0ca7-4d77-a7f7-afd5ffe8059f"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""0f3c84cd-0fdc-4074-ac8c-947d8695c817"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Use Nitro"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Movement
        m_Movement = asset.FindActionMap("Movement", throwIfNotFound: true);
        m_Movement_Move = m_Movement.FindAction("Move", throwIfNotFound: true);
        // Nitro
        m_Nitro = asset.FindActionMap("Nitro", throwIfNotFound: true);
        m_Nitro_UseNitro = m_Nitro.FindAction("Use Nitro", throwIfNotFound: true);
        m_Movement_Look = m_Movement.FindAction("Look", throwIfNotFound: true);
        m_Movement_Brake = m_Movement.FindAction("Brake", throwIfNotFound: true);
    }

    public void Dispose()
    {
        UnityEngine.Object.Destroy(asset);
    }

    public InputBinding? bindingMask
    {
        get => asset.bindingMask;
        set => asset.bindingMask = value;
    }

    public ReadOnlyArray<InputDevice>? devices
    {
        get => asset.devices;
        set => asset.devices = value;
    }

    public ReadOnlyArray<InputControlScheme> controlSchemes => asset.controlSchemes;

    public bool Contains(InputAction action)
    {
        return asset.Contains(action);
    }

    public IEnumerator<InputAction> GetEnumerator()
    {
        return asset.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public void Enable()
    {
        asset.Enable();
    }

    public void Disable()
    {
        asset.Disable();
    }

    // Movement
    private readonly InputActionMap m_Movement;
    private IMovementActions m_MovementActionsCallbackInterface;
    private readonly InputAction m_Movement_Move;
    private readonly InputAction m_Movement_Look;
    private readonly InputAction m_Movement_Brake;
    public struct MovementActions
    {
        private @Controls m_Wrapper;
        public MovementActions(@Controls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Move => m_Wrapper.m_Movement_Move;
        public InputAction @Look => m_Wrapper.m_Movement_Look;
        public InputAction @Brake => m_Wrapper.m_Movement_Brake;
        public InputActionMap Get() { return m_Wrapper.m_Movement; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(MovementActions set) { return set.Get(); }
        public void SetCallbacks(IMovementActions instance)
        {
            if (m_Wrapper.m_MovementActionsCallbackInterface != null)
            {
                @Move.started -= m_Wrapper.m_MovementActionsCallbackInterface.OnMove;
                @Move.performed -= m_Wrapper.m_MovementActionsCallbackInterface.OnMove;
                @Move.canceled -= m_Wrapper.m_MovementActionsCallbackInterface.OnMove;
                @Look.started -= m_Wrapper.m_MovementActionsCallbackInterface.OnLook;
                @Look.performed -= m_Wrapper.m_MovementActionsCallbackInterface.OnLook;
                @Look.canceled -= m_Wrapper.m_MovementActionsCallbackInterface.OnLook;
                @Brake.started -= m_Wrapper.m_MovementActionsCallbackInterface.OnBrake;
                @Brake.performed -= m_Wrapper.m_MovementActionsCallbackInterface.OnBrake;
                @Brake.canceled -= m_Wrapper.m_MovementActionsCallbackInterface.OnBrake;
            }
            m_Wrapper.m_MovementActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Move.started += instance.OnMove;
                @Move.performed += instance.OnMove;
                @Move.canceled += instance.OnMove;
                @Look.started += instance.OnLook;
                @Look.performed += instance.OnLook;
                @Look.canceled += instance.OnLook;
                @Brake.started += instance.OnBrake;
                @Brake.performed += instance.OnBrake;
                @Brake.canceled += instance.OnBrake;
            }
        }
    }
    public MovementActions @Movement => new MovementActions(this);

    // Nitro
    private readonly InputActionMap m_Nitro;
    private INitroActions m_NitroActionsCallbackInterface;
    private readonly InputAction m_Nitro_UseNitro;
    public struct NitroActions
    {
        private @Controls m_Wrapper;
        public NitroActions(@Controls wrapper) { m_Wrapper = wrapper; }
        public InputAction @UseNitro => m_Wrapper.m_Nitro_UseNitro;
        public InputActionMap Get() { return m_Wrapper.m_Nitro; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(NitroActions set) { return set.Get(); }
        public void SetCallbacks(INitroActions instance)
        {
            if (m_Wrapper.m_NitroActionsCallbackInterface != null)
            {
                @UseNitro.started -= m_Wrapper.m_NitroActionsCallbackInterface.OnUseNitro;
                @UseNitro.performed -= m_Wrapper.m_NitroActionsCallbackInterface.OnUseNitro;
                @UseNitro.canceled -= m_Wrapper.m_NitroActionsCallbackInterface.OnUseNitro;
            }
            m_Wrapper.m_NitroActionsCallbackInterface = instance;
            if (instance != null)
            {
                @UseNitro.started += instance.OnUseNitro;
                @UseNitro.performed += instance.OnUseNitro;
                @UseNitro.canceled += instance.OnUseNitro;
            }
        }
    }
    public NitroActions @Nitro => new NitroActions(this);
    public interface IMovementActions
    {
        void OnMove(InputAction.CallbackContext context);
        void OnLook(InputAction.CallbackContext context);
        void OnBrake(InputAction.CallbackContext context);
    }
    public interface INitroActions
    {
        void OnUseNitro(InputAction.CallbackContext context);
    }
}
