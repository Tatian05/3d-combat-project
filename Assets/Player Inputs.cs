//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.5.1
//     from Assets/Player Inputs.inputactions
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public partial class @PlayerInputs: IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerInputs()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""Player Inputs"",
    ""maps"": [
        {
            ""name"": ""Player"",
            ""id"": ""94766ff0-89ac-4a32-9dd7-a41f228d5876"",
            ""actions"": [
                {
                    ""name"": ""Movement"",
                    ""type"": ""Value"",
                    ""id"": ""cdd57204-39f4-4631-bd35-848dcb1b9162"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""RunStart"",
                    ""type"": ""Button"",
                    ""id"": ""46ada4c6-542d-46c4-a58b-3a594b29475b"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press"",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""RunEnd"",
                    ""type"": ""Button"",
                    ""id"": ""5ae182bd-6d01-4724-892b-54241587131c"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""BlockStart"",
                    ""type"": ""Button"",
                    ""id"": ""b7a93481-0fb0-4875-b97d-878e176706ef"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press"",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""BlockEnd"",
                    ""type"": ""Button"",
                    ""id"": ""bc173c8d-787d-425e-b2ba-0e29b31e7ea8"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press(behavior=1)"",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""SwordStart"",
                    ""type"": ""Button"",
                    ""id"": ""b7df217a-7436-4453-8e25-b34e178a14d4"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press"",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""SwordEnd"",
                    ""type"": ""Button"",
                    ""id"": ""ee4dae6b-fb0d-41e3-81a7-e13cbf0b9257"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press(behavior=1)"",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""9f6e092a-d6fc-4454-b2d2-b8b38f94664c"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""24ca5b5b-e47f-47f0-8dd9-79cc10408180"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""1bb49311-80df-43ae-887d-e614bc79e99e"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""cd1b9d1e-90c4-46ce-8750-bb61891f361d"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""e14a276a-a260-45e9-95c2-fead88744aff"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""f9d6033e-5038-4699-baa7-4e54294189ef"",
                    ""path"": ""<Keyboard>/shift"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""RunStart"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""2868ee99-2818-405c-98ec-f01d299aef1f"",
                    ""path"": ""<Keyboard>/shift"",
                    ""interactions"": ""Press(behavior=1)"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""RunEnd"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""7dfe9657-98c3-4c84-a490-1758e23d4891"",
                    ""path"": ""<Mouse>/rightButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""BlockStart"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""619aa977-45f7-4669-8f7a-ece0752977cd"",
                    ""path"": ""<Mouse>/rightButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""BlockEnd"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""97030cc5-3ac5-43cb-91b3-b7edd04a8cc6"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""SwordStart"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""4a5607a1-d794-47b5-bc36-7d88aff39ff0"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""SwordEnd"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""Keyboard"",
            ""bindingGroup"": ""Keyboard"",
            ""devices"": [
                {
                    ""devicePath"": ""<Keyboard>"",
                    ""isOptional"": false,
                    ""isOR"": false
                },
                {
                    ""devicePath"": ""<VirtualMouse>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        }
    ]
}");
        // Player
        m_Player = asset.FindActionMap("Player", throwIfNotFound: true);
        m_Player_Movement = m_Player.FindAction("Movement", throwIfNotFound: true);
        m_Player_RunStart = m_Player.FindAction("RunStart", throwIfNotFound: true);
        m_Player_RunEnd = m_Player.FindAction("RunEnd", throwIfNotFound: true);
        m_Player_BlockStart = m_Player.FindAction("BlockStart", throwIfNotFound: true);
        m_Player_BlockEnd = m_Player.FindAction("BlockEnd", throwIfNotFound: true);
        m_Player_SwordStart = m_Player.FindAction("SwordStart", throwIfNotFound: true);
        m_Player_SwordEnd = m_Player.FindAction("SwordEnd", throwIfNotFound: true);
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

    public IEnumerable<InputBinding> bindings => asset.bindings;

    public InputAction FindAction(string actionNameOrId, bool throwIfNotFound = false)
    {
        return asset.FindAction(actionNameOrId, throwIfNotFound);
    }

    public int FindBinding(InputBinding bindingMask, out InputAction action)
    {
        return asset.FindBinding(bindingMask, out action);
    }

    // Player
    private readonly InputActionMap m_Player;
    private List<IPlayerActions> m_PlayerActionsCallbackInterfaces = new List<IPlayerActions>();
    private readonly InputAction m_Player_Movement;
    private readonly InputAction m_Player_RunStart;
    private readonly InputAction m_Player_RunEnd;
    private readonly InputAction m_Player_BlockStart;
    private readonly InputAction m_Player_BlockEnd;
    private readonly InputAction m_Player_SwordStart;
    private readonly InputAction m_Player_SwordEnd;
    public struct PlayerActions
    {
        private @PlayerInputs m_Wrapper;
        public PlayerActions(@PlayerInputs wrapper) { m_Wrapper = wrapper; }
        public InputAction @Movement => m_Wrapper.m_Player_Movement;
        public InputAction @RunStart => m_Wrapper.m_Player_RunStart;
        public InputAction @RunEnd => m_Wrapper.m_Player_RunEnd;
        public InputAction @BlockStart => m_Wrapper.m_Player_BlockStart;
        public InputAction @BlockEnd => m_Wrapper.m_Player_BlockEnd;
        public InputAction @SwordStart => m_Wrapper.m_Player_SwordStart;
        public InputAction @SwordEnd => m_Wrapper.m_Player_SwordEnd;
        public InputActionMap Get() { return m_Wrapper.m_Player; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerActions set) { return set.Get(); }
        public void AddCallbacks(IPlayerActions instance)
        {
            if (instance == null || m_Wrapper.m_PlayerActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_PlayerActionsCallbackInterfaces.Add(instance);
            @Movement.started += instance.OnMovement;
            @Movement.performed += instance.OnMovement;
            @Movement.canceled += instance.OnMovement;
            @RunStart.started += instance.OnRunStart;
            @RunStart.performed += instance.OnRunStart;
            @RunStart.canceled += instance.OnRunStart;
            @RunEnd.started += instance.OnRunEnd;
            @RunEnd.performed += instance.OnRunEnd;
            @RunEnd.canceled += instance.OnRunEnd;
            @BlockStart.started += instance.OnBlockStart;
            @BlockStart.performed += instance.OnBlockStart;
            @BlockStart.canceled += instance.OnBlockStart;
            @BlockEnd.started += instance.OnBlockEnd;
            @BlockEnd.performed += instance.OnBlockEnd;
            @BlockEnd.canceled += instance.OnBlockEnd;
            @SwordStart.started += instance.OnSwordStart;
            @SwordStart.performed += instance.OnSwordStart;
            @SwordStart.canceled += instance.OnSwordStart;
            @SwordEnd.started += instance.OnSwordEnd;
            @SwordEnd.performed += instance.OnSwordEnd;
            @SwordEnd.canceled += instance.OnSwordEnd;
        }

        private void UnregisterCallbacks(IPlayerActions instance)
        {
            @Movement.started -= instance.OnMovement;
            @Movement.performed -= instance.OnMovement;
            @Movement.canceled -= instance.OnMovement;
            @RunStart.started -= instance.OnRunStart;
            @RunStart.performed -= instance.OnRunStart;
            @RunStart.canceled -= instance.OnRunStart;
            @RunEnd.started -= instance.OnRunEnd;
            @RunEnd.performed -= instance.OnRunEnd;
            @RunEnd.canceled -= instance.OnRunEnd;
            @BlockStart.started -= instance.OnBlockStart;
            @BlockStart.performed -= instance.OnBlockStart;
            @BlockStart.canceled -= instance.OnBlockStart;
            @BlockEnd.started -= instance.OnBlockEnd;
            @BlockEnd.performed -= instance.OnBlockEnd;
            @BlockEnd.canceled -= instance.OnBlockEnd;
            @SwordStart.started -= instance.OnSwordStart;
            @SwordStart.performed -= instance.OnSwordStart;
            @SwordStart.canceled -= instance.OnSwordStart;
            @SwordEnd.started -= instance.OnSwordEnd;
            @SwordEnd.performed -= instance.OnSwordEnd;
            @SwordEnd.canceled -= instance.OnSwordEnd;
        }

        public void RemoveCallbacks(IPlayerActions instance)
        {
            if (m_Wrapper.m_PlayerActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(IPlayerActions instance)
        {
            foreach (var item in m_Wrapper.m_PlayerActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_PlayerActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public PlayerActions @Player => new PlayerActions(this);
    private int m_KeyboardSchemeIndex = -1;
    public InputControlScheme KeyboardScheme
    {
        get
        {
            if (m_KeyboardSchemeIndex == -1) m_KeyboardSchemeIndex = asset.FindControlSchemeIndex("Keyboard");
            return asset.controlSchemes[m_KeyboardSchemeIndex];
        }
    }
    public interface IPlayerActions
    {
        void OnMovement(InputAction.CallbackContext context);
        void OnRunStart(InputAction.CallbackContext context);
        void OnRunEnd(InputAction.CallbackContext context);
        void OnBlockStart(InputAction.CallbackContext context);
        void OnBlockEnd(InputAction.CallbackContext context);
        void OnSwordStart(InputAction.CallbackContext context);
        void OnSwordEnd(InputAction.CallbackContext context);
    }
}
