//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.11.2
//     from Assets/NewPlayerController.inputactions
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

public partial class @NewPlayerController: IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @NewPlayerController()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""NewPlayerController"",
    ""maps"": [
        {
            ""name"": ""horizontal"",
            ""id"": ""401d6758-f1e3-451f-a84f-eec57c2575f6"",
            ""actions"": [
                {
                    ""name"": ""Move"",
                    ""type"": ""Value"",
                    ""id"": ""d0871eca-779a-44f7-85de-d6a427b6eda3"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": ""Press(behavior=2)"",
                    ""initialStateCheck"": true
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""8c829517-23ea-44b4-a2cd-9dd0e10d2b0f"",
                    ""path"": """",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""arrowkeys"",
                    ""id"": ""71cd5d77-e7f2-4fcd-962d-33a9a50a6797"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""64e01e42-9c93-4ce3-a5d6-fafd209f129b"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""58119ab1-b661-400c-8918-6607965eab3d"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""letterkeys"",
                    ""id"": ""bd2a4071-c2f1-4439-bfd0-c01bcba337f2"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""41b91d97-451b-4531-ad1b-39addae9b653"",
                    ""path"": ""<Keyboard>/q"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""acfcb8e6-fb7e-45cd-afa6-c539c40f7f06"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // horizontal
        m_horizontal = asset.FindActionMap("horizontal", throwIfNotFound: true);
        m_horizontal_Move = m_horizontal.FindAction("Move", throwIfNotFound: true);
    }

    ~@NewPlayerController()
    {
        UnityEngine.Debug.Assert(!m_horizontal.enabled, "This will cause a leak and performance issues, NewPlayerController.horizontal.Disable() has not been called.");
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

    // horizontal
    private readonly InputActionMap m_horizontal;
    private List<IHorizontalActions> m_HorizontalActionsCallbackInterfaces = new List<IHorizontalActions>();
    private readonly InputAction m_horizontal_Move;
    public struct HorizontalActions
    {
        private @NewPlayerController m_Wrapper;
        public HorizontalActions(@NewPlayerController wrapper) { m_Wrapper = wrapper; }
        public InputAction @Move => m_Wrapper.m_horizontal_Move;
        public InputActionMap Get() { return m_Wrapper.m_horizontal; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(HorizontalActions set) { return set.Get(); }
        public void AddCallbacks(IHorizontalActions instance)
        {
            if (instance == null || m_Wrapper.m_HorizontalActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_HorizontalActionsCallbackInterfaces.Add(instance);
            @Move.started += instance.OnMove;
            @Move.performed += instance.OnMove;
            @Move.canceled += instance.OnMove;
        }

        private void UnregisterCallbacks(IHorizontalActions instance)
        {
            @Move.started -= instance.OnMove;
            @Move.performed -= instance.OnMove;
            @Move.canceled -= instance.OnMove;
        }

        public void RemoveCallbacks(IHorizontalActions instance)
        {
            if (m_Wrapper.m_HorizontalActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(IHorizontalActions instance)
        {
            foreach (var item in m_Wrapper.m_HorizontalActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_HorizontalActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public HorizontalActions @horizontal => new HorizontalActions(this);
    public interface IHorizontalActions
    {
        void OnMove(InputAction.CallbackContext context);
    }
}
