// GENERATED AUTOMATICALLY FROM 'Assets/Mads/InputActionsForVR.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @InputActionsForVR : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @InputActionsForVR()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""InputActionsForVR"",
    ""maps"": [
        {
            ""name"": ""Gamepad"",
            ""id"": ""ab898fae-221a-4072-b0c3-c9a2f51631fc"",
            ""actions"": [
                {
                    ""name"": ""MoveVector"",
                    ""type"": ""PassThrough"",
                    ""id"": ""0ec894c2-c8fb-437d-a11a-9fb43b6d8997"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""RotVector"",
                    ""type"": ""PassThrough"",
                    ""id"": ""dcd96570-8818-46b0-b2bb-b6b57b8351d0"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Jump"",
                    ""type"": ""Button"",
                    ""id"": ""b4bc1eeb-205e-41c8-ad70-97b9bfc6217c"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Interact"",
                    ""type"": ""Button"",
                    ""id"": ""c9f87ef9-e96a-4518-bf4a-9e544777ec6c"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""26fc0695-12c5-40c4-9006-5cfc1f34cd68"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveVector"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""b35806a0-7344-4308-ab88-b2b48c95e86f"",
                    ""path"": ""<Gamepad>/leftStick/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""VR"",
                    ""action"": ""MoveVector"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""1fac2502-b711-4c2f-a70d-aab001e3306b"",
                    ""path"": ""<Gamepad>/leftStick/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""VR"",
                    ""action"": ""MoveVector"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""186b23f9-6460-44cb-94f4-afa94a998062"",
                    ""path"": ""<Gamepad>/leftStick/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""VR"",
                    ""action"": ""MoveVector"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""12cb536b-408c-4659-be8d-8210fc144683"",
                    ""path"": ""<Gamepad>/leftStick/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""VR"",
                    ""action"": ""MoveVector"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""af7edaa9-e9f6-42ad-a3f0-d525b1300eec"",
                    ""path"": ""2DVector(mode=2)"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""RotVector"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""fc4f0474-5376-45de-a681-a0f270ce3ac1"",
                    ""path"": ""<Gamepad>/rightStick/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""VR"",
                    ""action"": ""RotVector"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""bc07b280-183c-4df7-9a96-589377721b23"",
                    ""path"": ""<Gamepad>/rightStick/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""VR"",
                    ""action"": ""RotVector"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""0a906fe9-2cbf-4b49-adfa-51df8567eec4"",
                    ""path"": ""<Gamepad>/rightStick/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""VR"",
                    ""action"": ""RotVector"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""ccff11e9-2dfd-4d2c-9857-d350aa1bc5e3"",
                    ""path"": ""<Gamepad>/rightStick/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""VR"",
                    ""action"": ""RotVector"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""d71db1cd-db13-41f3-a325-ed56c902e247"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""VR"",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""f2bb1381-9a10-45e6-9ca3-2713455968f1"",
                    ""path"": ""<Gamepad>/buttonWest"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""VR"",
                    ""action"": ""Interact"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Android"",
            ""id"": ""8c8eebf9-b735-4534-8698-7c3449dec8dc"",
            ""actions"": [
                {
                    ""name"": ""Attitude"",
                    ""type"": ""PassThrough"",
                    ""id"": ""ace4d290-daba-4a16-bc86-8fbab8c47374"",
                    ""expectedControlType"": ""Quaternion"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""47891430-1b9f-4559-a005-acb5e17bf06b"",
                    ""path"": ""<AttitudeSensor>/attitude"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Attitude"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""VR"",
            ""bindingGroup"": ""VR"",
            ""devices"": [
                {
                    ""devicePath"": ""<Gamepad>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        }
    ]
}");
        // Gamepad
        m_Gamepad = asset.FindActionMap("Gamepad", throwIfNotFound: true);
        m_Gamepad_MoveVector = m_Gamepad.FindAction("MoveVector", throwIfNotFound: true);
        m_Gamepad_RotVector = m_Gamepad.FindAction("RotVector", throwIfNotFound: true);
        m_Gamepad_Jump = m_Gamepad.FindAction("Jump", throwIfNotFound: true);
        m_Gamepad_Interact = m_Gamepad.FindAction("Interact", throwIfNotFound: true);
        // Android
        m_Android = asset.FindActionMap("Android", throwIfNotFound: true);
        m_Android_Attitude = m_Android.FindAction("Attitude", throwIfNotFound: true);
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

    // Gamepad
    private readonly InputActionMap m_Gamepad;
    private IGamepadActions m_GamepadActionsCallbackInterface;
    private readonly InputAction m_Gamepad_MoveVector;
    private readonly InputAction m_Gamepad_RotVector;
    private readonly InputAction m_Gamepad_Jump;
    private readonly InputAction m_Gamepad_Interact;
    public struct GamepadActions
    {
        private @InputActionsForVR m_Wrapper;
        public GamepadActions(@InputActionsForVR wrapper) { m_Wrapper = wrapper; }
        public InputAction @MoveVector => m_Wrapper.m_Gamepad_MoveVector;
        public InputAction @RotVector => m_Wrapper.m_Gamepad_RotVector;
        public InputAction @Jump => m_Wrapper.m_Gamepad_Jump;
        public InputAction @Interact => m_Wrapper.m_Gamepad_Interact;
        public InputActionMap Get() { return m_Wrapper.m_Gamepad; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(GamepadActions set) { return set.Get(); }
        public void SetCallbacks(IGamepadActions instance)
        {
            if (m_Wrapper.m_GamepadActionsCallbackInterface != null)
            {
                @MoveVector.started -= m_Wrapper.m_GamepadActionsCallbackInterface.OnMoveVector;
                @MoveVector.performed -= m_Wrapper.m_GamepadActionsCallbackInterface.OnMoveVector;
                @MoveVector.canceled -= m_Wrapper.m_GamepadActionsCallbackInterface.OnMoveVector;
                @RotVector.started -= m_Wrapper.m_GamepadActionsCallbackInterface.OnRotVector;
                @RotVector.performed -= m_Wrapper.m_GamepadActionsCallbackInterface.OnRotVector;
                @RotVector.canceled -= m_Wrapper.m_GamepadActionsCallbackInterface.OnRotVector;
                @Jump.started -= m_Wrapper.m_GamepadActionsCallbackInterface.OnJump;
                @Jump.performed -= m_Wrapper.m_GamepadActionsCallbackInterface.OnJump;
                @Jump.canceled -= m_Wrapper.m_GamepadActionsCallbackInterface.OnJump;
                @Interact.started -= m_Wrapper.m_GamepadActionsCallbackInterface.OnInteract;
                @Interact.performed -= m_Wrapper.m_GamepadActionsCallbackInterface.OnInteract;
                @Interact.canceled -= m_Wrapper.m_GamepadActionsCallbackInterface.OnInteract;
            }
            m_Wrapper.m_GamepadActionsCallbackInterface = instance;
            if (instance != null)
            {
                @MoveVector.started += instance.OnMoveVector;
                @MoveVector.performed += instance.OnMoveVector;
                @MoveVector.canceled += instance.OnMoveVector;
                @RotVector.started += instance.OnRotVector;
                @RotVector.performed += instance.OnRotVector;
                @RotVector.canceled += instance.OnRotVector;
                @Jump.started += instance.OnJump;
                @Jump.performed += instance.OnJump;
                @Jump.canceled += instance.OnJump;
                @Interact.started += instance.OnInteract;
                @Interact.performed += instance.OnInteract;
                @Interact.canceled += instance.OnInteract;
            }
        }
    }
    public GamepadActions @Gamepad => new GamepadActions(this);

    // Android
    private readonly InputActionMap m_Android;
    private IAndroidActions m_AndroidActionsCallbackInterface;
    private readonly InputAction m_Android_Attitude;
    public struct AndroidActions
    {
        private @InputActionsForVR m_Wrapper;
        public AndroidActions(@InputActionsForVR wrapper) { m_Wrapper = wrapper; }
        public InputAction @Attitude => m_Wrapper.m_Android_Attitude;
        public InputActionMap Get() { return m_Wrapper.m_Android; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(AndroidActions set) { return set.Get(); }
        public void SetCallbacks(IAndroidActions instance)
        {
            if (m_Wrapper.m_AndroidActionsCallbackInterface != null)
            {
                @Attitude.started -= m_Wrapper.m_AndroidActionsCallbackInterface.OnAttitude;
                @Attitude.performed -= m_Wrapper.m_AndroidActionsCallbackInterface.OnAttitude;
                @Attitude.canceled -= m_Wrapper.m_AndroidActionsCallbackInterface.OnAttitude;
            }
            m_Wrapper.m_AndroidActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Attitude.started += instance.OnAttitude;
                @Attitude.performed += instance.OnAttitude;
                @Attitude.canceled += instance.OnAttitude;
            }
        }
    }
    public AndroidActions @Android => new AndroidActions(this);
    private int m_VRSchemeIndex = -1;
    public InputControlScheme VRScheme
    {
        get
        {
            if (m_VRSchemeIndex == -1) m_VRSchemeIndex = asset.FindControlSchemeIndex("VR");
            return asset.controlSchemes[m_VRSchemeIndex];
        }
    }
    public interface IGamepadActions
    {
        void OnMoveVector(InputAction.CallbackContext context);
        void OnRotVector(InputAction.CallbackContext context);
        void OnJump(InputAction.CallbackContext context);
        void OnInteract(InputAction.CallbackContext context);
    }
    public interface IAndroidActions
    {
        void OnAttitude(InputAction.CallbackContext context);
    }
}
