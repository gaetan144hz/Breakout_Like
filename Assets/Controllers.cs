// GENERATED AUTOMATICALLY FROM 'Assets/Controllers.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @Controllers : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @Controllers()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""Controllers"",
    ""maps"": [
        {
            ""name"": ""player"",
            ""id"": ""72c3c1fd-380d-47fa-8caa-ae66fe1f4e97"",
            ""actions"": [
                {
                    ""name"": ""move"",
                    ""type"": ""PassThrough"",
                    ""id"": ""379a7884-42d6-4d09-b787-2e0c105289d2"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""be1290c7-e93e-4311-b1ba-382d389c60ae"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""left"",
                    ""id"": ""06707a27-6a0e-48f7-9429-e145ce92ce3d"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""6f08fad9-06ff-4e14-90b4-52d663480409"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""0ec7aacf-3cd5-4d3b-b2a2-c47b0ed93f85"",
                    ""path"": ""<Gamepad>/leftStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Controllers"",
                    ""action"": ""move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""3cc93d99-0578-40af-aa0f-f3bc78b5f55e"",
                    ""path"": ""<Gamepad>/dpad"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Controllers"",
                    ""action"": ""move"",
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
                }
            ]
        },
        {
            ""name"": ""Controllers"",
            ""bindingGroup"": ""Controllers"",
            ""devices"": [
                {
                    ""devicePath"": ""<XInputController>"",
                    ""isOptional"": true,
                    ""isOR"": false
                }
            ]
        }
    ]
}");
        // player
        m_player = asset.FindActionMap("player", throwIfNotFound: true);
        m_player_move = m_player.FindAction("move", throwIfNotFound: true);
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

    // player
    private readonly InputActionMap m_player;
    private IPlayerActions m_PlayerActionsCallbackInterface;
    private readonly InputAction m_player_move;
    public struct PlayerActions
    {
        private @Controllers m_Wrapper;
        public PlayerActions(@Controllers wrapper) { m_Wrapper = wrapper; }
        public InputAction @move => m_Wrapper.m_player_move;
        public InputActionMap Get() { return m_Wrapper.m_player; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerActions set) { return set.Get(); }
        public void SetCallbacks(IPlayerActions instance)
        {
            if (m_Wrapper.m_PlayerActionsCallbackInterface != null)
            {
                @move.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMove;
                @move.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMove;
                @move.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMove;
            }
            m_Wrapper.m_PlayerActionsCallbackInterface = instance;
            if (instance != null)
            {
                @move.started += instance.OnMove;
                @move.performed += instance.OnMove;
                @move.canceled += instance.OnMove;
            }
        }
    }
    public PlayerActions @player => new PlayerActions(this);
    private int m_KeyboardSchemeIndex = -1;
    public InputControlScheme KeyboardScheme
    {
        get
        {
            if (m_KeyboardSchemeIndex == -1) m_KeyboardSchemeIndex = asset.FindControlSchemeIndex("Keyboard");
            return asset.controlSchemes[m_KeyboardSchemeIndex];
        }
    }
    private int m_ControllersSchemeIndex = -1;
    public InputControlScheme ControllersScheme
    {
        get
        {
            if (m_ControllersSchemeIndex == -1) m_ControllersSchemeIndex = asset.FindControlSchemeIndex("Controllers");
            return asset.controlSchemes[m_ControllersSchemeIndex];
        }
    }
    public interface IPlayerActions
    {
        void OnMove(InputAction.CallbackContext context);
    }
}
