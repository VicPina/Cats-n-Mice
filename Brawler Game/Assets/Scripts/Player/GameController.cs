// GENERATED AUTOMATICALLY FROM 'Assets/Scripts/Player/GameController.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @GameController : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @GameController()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""GameController"",
    ""maps"": [
        {
            ""name"": ""PlayerControls"",
            ""id"": ""34f85f14-c22a-4d3d-8b84-e1cb6ead7756"",
            ""actions"": [
                {
                    ""name"": ""Crouch"",
                    ""type"": ""Button"",
                    ""id"": ""4869058a-9ff0-4f88-9443-9e6fdad679ca"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Interact"",
                    ""type"": ""Button"",
                    ""id"": ""426ea27a-f0c9-4b3e-8ab6-91c2de246aaa"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Run"",
                    ""type"": ""Button"",
                    ""id"": ""91b4a2ee-2156-4c6a-b65c-4e3bbd921efb"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Move"",
                    ""type"": ""Value"",
                    ""id"": ""66a0a279-18d3-422d-8784-eaf8420b9aeb"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""71464376-051c-467e-a307-cea75a619938"",
                    ""path"": ""<Gamepad>/leftTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Crouch"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""e9e5a61c-de2e-45bb-bb8a-640537a17e0f"",
                    ""path"": ""<HID::HORI CO.,LTD. HORIPAD mini4>/button7"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Crouch"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""9eadad0f-d7ff-478c-8888-a6148185b3f6"",
                    ""path"": ""<Keyboard>/ctrl"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Crouch"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""2e4764e5-e873-45fa-957a-99668f38144f"",
                    ""path"": ""<Gamepad>/leftStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""69593552-e4bb-46a3-ae3e-4970be6b2579"",
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
                    ""id"": ""3176a9f3-6f35-4e55-bf0e-7c0a8b25f8fd"",
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
                    ""id"": ""fa61f117-1595-4f07-9c45-b83ca5668a38"",
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
                    ""id"": ""30c32c35-2e10-4dbb-904c-1d1b88106e57"",
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
                    ""id"": ""524856ef-34a3-4557-8c13-03daa4588a92"",
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
                    ""id"": ""fd0646bf-f3b8-437e-9f10-20ff47a96ea4"",
                    ""path"": ""<Joystick>/stick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""6e4372b4-63f6-4d7b-a133-efdc45a95315"",
                    ""path"": ""<Gamepad>/buttonWest"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Interact"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""8906c43d-32e4-44c8-8238-e0e26f64aa63"",
                    ""path"": ""<Joystick>/trigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Interact"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""37d0f08d-dfac-45b5-b74d-2597b0a7295b"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Interact"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""182e976e-edf5-410c-a7f4-f74346e576ca"",
                    ""path"": ""<Gamepad>/leftShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Run"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""e9b2642f-3a71-4ce4-b270-43f56d09f367"",
                    ""path"": ""<HID::HORI CO.,LTD. HORIPAD mini4>/button5"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Run"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""bf6afa31-5937-4505-8839-25d469776b60"",
                    ""path"": ""<Keyboard>/shift"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Run"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Menu"",
            ""id"": ""fd534f7d-30d8-4220-95b9-66cdafc0120b"",
            ""actions"": [
                {
                    ""name"": ""Move"",
                    ""type"": ""Value"",
                    ""id"": ""14368aa0-b741-407b-9ceb-3a18c80667ec"",
                    ""expectedControlType"": ""Dpad"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Submit"",
                    ""type"": ""Button"",
                    ""id"": ""67413a08-2bb8-460b-bf5d-a270251f6058"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Cancel"",
                    ""type"": ""Button"",
                    ""id"": ""05473840-f1fc-491a-abfc-4405baaac11a"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""24e02997-8377-425f-8421-fc7dcaea5604"",
                    ""path"": ""<Gamepad>/dpad"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""53eefc28-cea4-437e-8f4c-e7df8ffa1926"",
                    ""path"": ""<HID::HORI CO.,LTD. HORIPAD mini4>/hat"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""WASD"",
                    ""id"": ""a394f071-4ff5-426e-989e-e5c2c314ef7a"",
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
                    ""id"": ""135472af-a1d9-4d51-8399-aa31cd23863e"",
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
                    ""id"": ""0d2d5916-51d5-49e2-a271-6294360513a0"",
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
                    ""id"": ""243c12bc-eb49-4a73-9fee-a3f2af5622e2"",
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
                    ""id"": ""4c2f67e1-9684-4c49-8ab1-2309c092da1e"",
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
                    ""id"": ""910cc2c2-8be7-4532-abb5-34335d67d0f9"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Submit"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""21b7b43a-e192-495f-9149-4ab2bb7aa2ed"",
                    ""path"": ""<HID::HORI CO.,LTD. HORIPAD mini4>/button2"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Submit"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""2bca8196-e2c7-4f7d-980f-6e4097652e93"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Submit"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""76461d9b-968b-42d5-90b2-e28bc23b3d67"",
                    ""path"": ""<HID::HORI CO.,LTD. HORIPAD mini4>/button3"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Cancel"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""69e7f5ce-6dc1-4bf1-9d35-ddf09f8b8c03"",
                    ""path"": ""<Gamepad>/buttonEast"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Cancel"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""09ca9571-7bc1-4956-9e26-e69f2c29ae49"",
                    ""path"": ""<Keyboard>/escape"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Cancel"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // PlayerControls
        m_PlayerControls = asset.FindActionMap("PlayerControls", throwIfNotFound: true);
        m_PlayerControls_Crouch = m_PlayerControls.FindAction("Crouch", throwIfNotFound: true);
        m_PlayerControls_Interact = m_PlayerControls.FindAction("Interact", throwIfNotFound: true);
        m_PlayerControls_Run = m_PlayerControls.FindAction("Run", throwIfNotFound: true);
        m_PlayerControls_Move = m_PlayerControls.FindAction("Move", throwIfNotFound: true);
        // Menu
        m_Menu = asset.FindActionMap("Menu", throwIfNotFound: true);
        m_Menu_Move = m_Menu.FindAction("Move", throwIfNotFound: true);
        m_Menu_Submit = m_Menu.FindAction("Submit", throwIfNotFound: true);
        m_Menu_Cancel = m_Menu.FindAction("Cancel", throwIfNotFound: true);
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

    // PlayerControls
    private readonly InputActionMap m_PlayerControls;
    private IPlayerControlsActions m_PlayerControlsActionsCallbackInterface;
    private readonly InputAction m_PlayerControls_Crouch;
    private readonly InputAction m_PlayerControls_Interact;
    private readonly InputAction m_PlayerControls_Run;
    private readonly InputAction m_PlayerControls_Move;
    public struct PlayerControlsActions
    {
        private @GameController m_Wrapper;
        public PlayerControlsActions(@GameController wrapper) { m_Wrapper = wrapper; }
        public InputAction @Crouch => m_Wrapper.m_PlayerControls_Crouch;
        public InputAction @Interact => m_Wrapper.m_PlayerControls_Interact;
        public InputAction @Run => m_Wrapper.m_PlayerControls_Run;
        public InputAction @Move => m_Wrapper.m_PlayerControls_Move;
        public InputActionMap Get() { return m_Wrapper.m_PlayerControls; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerControlsActions set) { return set.Get(); }
        public void SetCallbacks(IPlayerControlsActions instance)
        {
            if (m_Wrapper.m_PlayerControlsActionsCallbackInterface != null)
            {
                @Crouch.started -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnCrouch;
                @Crouch.performed -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnCrouch;
                @Crouch.canceled -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnCrouch;
                @Interact.started -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnInteract;
                @Interact.performed -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnInteract;
                @Interact.canceled -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnInteract;
                @Run.started -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnRun;
                @Run.performed -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnRun;
                @Run.canceled -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnRun;
                @Move.started -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnMove;
                @Move.performed -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnMove;
                @Move.canceled -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnMove;
            }
            m_Wrapper.m_PlayerControlsActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Crouch.started += instance.OnCrouch;
                @Crouch.performed += instance.OnCrouch;
                @Crouch.canceled += instance.OnCrouch;
                @Interact.started += instance.OnInteract;
                @Interact.performed += instance.OnInteract;
                @Interact.canceled += instance.OnInteract;
                @Run.started += instance.OnRun;
                @Run.performed += instance.OnRun;
                @Run.canceled += instance.OnRun;
                @Move.started += instance.OnMove;
                @Move.performed += instance.OnMove;
                @Move.canceled += instance.OnMove;
            }
        }
    }
    public PlayerControlsActions @PlayerControls => new PlayerControlsActions(this);

    // Menu
    private readonly InputActionMap m_Menu;
    private IMenuActions m_MenuActionsCallbackInterface;
    private readonly InputAction m_Menu_Move;
    private readonly InputAction m_Menu_Submit;
    private readonly InputAction m_Menu_Cancel;
    public struct MenuActions
    {
        private @GameController m_Wrapper;
        public MenuActions(@GameController wrapper) { m_Wrapper = wrapper; }
        public InputAction @Move => m_Wrapper.m_Menu_Move;
        public InputAction @Submit => m_Wrapper.m_Menu_Submit;
        public InputAction @Cancel => m_Wrapper.m_Menu_Cancel;
        public InputActionMap Get() { return m_Wrapper.m_Menu; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(MenuActions set) { return set.Get(); }
        public void SetCallbacks(IMenuActions instance)
        {
            if (m_Wrapper.m_MenuActionsCallbackInterface != null)
            {
                @Move.started -= m_Wrapper.m_MenuActionsCallbackInterface.OnMove;
                @Move.performed -= m_Wrapper.m_MenuActionsCallbackInterface.OnMove;
                @Move.canceled -= m_Wrapper.m_MenuActionsCallbackInterface.OnMove;
                @Submit.started -= m_Wrapper.m_MenuActionsCallbackInterface.OnSubmit;
                @Submit.performed -= m_Wrapper.m_MenuActionsCallbackInterface.OnSubmit;
                @Submit.canceled -= m_Wrapper.m_MenuActionsCallbackInterface.OnSubmit;
                @Cancel.started -= m_Wrapper.m_MenuActionsCallbackInterface.OnCancel;
                @Cancel.performed -= m_Wrapper.m_MenuActionsCallbackInterface.OnCancel;
                @Cancel.canceled -= m_Wrapper.m_MenuActionsCallbackInterface.OnCancel;
            }
            m_Wrapper.m_MenuActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Move.started += instance.OnMove;
                @Move.performed += instance.OnMove;
                @Move.canceled += instance.OnMove;
                @Submit.started += instance.OnSubmit;
                @Submit.performed += instance.OnSubmit;
                @Submit.canceled += instance.OnSubmit;
                @Cancel.started += instance.OnCancel;
                @Cancel.performed += instance.OnCancel;
                @Cancel.canceled += instance.OnCancel;
            }
        }
    }
    public MenuActions @Menu => new MenuActions(this);
    public interface IPlayerControlsActions
    {
        void OnCrouch(InputAction.CallbackContext context);
        void OnInteract(InputAction.CallbackContext context);
        void OnRun(InputAction.CallbackContext context);
        void OnMove(InputAction.CallbackContext context);
    }
    public interface IMenuActions
    {
        void OnMove(InputAction.CallbackContext context);
        void OnSubmit(InputAction.CallbackContext context);
        void OnCancel(InputAction.CallbackContext context);
    }
}
