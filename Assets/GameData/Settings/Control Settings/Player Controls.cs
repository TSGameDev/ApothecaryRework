//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.3.0
//     from Assets/GameData/Settings/Control Settings/Player Controls.inputactions
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

namespace TSGameDev.Controls
{
    public partial class @PlayerControls : IInputActionCollection2, IDisposable
    {
        public InputActionAsset asset { get; }
        public @PlayerControls()
        {
            asset = InputActionAsset.FromJson(@"{
    ""name"": ""Player Controls"",
    ""maps"": [
        {
            ""name"": ""Game"",
            ""id"": ""0737c800-3afc-4794-ad43-f8d3958fa75f"",
            ""actions"": [
                {
                    ""name"": ""MouseRightClick"",
                    ""type"": ""Button"",
                    ""id"": ""4f24feec-6688-4326-95b8-ebbc412ced1f"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""ShiftHold"",
                    ""type"": ""Button"",
                    ""id"": ""9c5f351b-123b-4ad4-99b3-1703f801472c"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press(behavior=2)"",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Camera Movement"",
                    ""type"": ""PassThrough"",
                    ""id"": ""a9410ebb-4cc7-455b-9a36-e0e66d85f6a1"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Camera Rotation"",
                    ""type"": ""Button"",
                    ""id"": ""61d1617c-07c6-4cc9-91ce-4e35369c4203"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Camera Center"",
                    ""type"": ""Button"",
                    ""id"": ""dc2ca71d-9b7c-4b83-bb1d-d87632f4d2fe"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Camera Zoom"",
                    ""type"": ""Value"",
                    ""id"": ""b9b4b959-c949-4c61-b2e4-aace95054937"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Inventory"",
                    ""type"": ""Button"",
                    ""id"": ""3c7f2071-43b2-4c7b-9c4f-870c112e862a"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press"",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Equipment"",
                    ""type"": ""Button"",
                    ""id"": ""92c1cb3c-4341-4d12-967d-c5b789f59eec"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Interaction"",
                    ""type"": ""Button"",
                    ""id"": ""7be2995c-abac-42e4-beb1-f38316a04fee"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""4e6a6d94-3ba2-4c82-8a80-c695340d1b3e"",
                    ""path"": ""<Mouse>/rightButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MouseRightClick"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""86433340-2056-4d4c-8bef-79b3a3091a64"",
                    ""path"": ""<Keyboard>/shift"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ShiftHold"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""83b87409-4391-4647-9ad9-133402ffe73f"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Camera Movement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""f7359bb3-f26a-4331-911c-ab5ae07dc47a"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Camera Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""0f59e96f-4f65-4540-8c0e-073d51d499a7"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Camera Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""c4d07014-5445-4d8f-992c-42b911f06d76"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Camera Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""b5ecce93-3d12-4b23-bb12-5072654392e1"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Camera Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""1D Axis"",
                    ""id"": ""1cbd1e2f-fd61-4ac4-9b42-01693d6039a3"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Camera Rotation"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""fbc687d0-f9ce-42a3-b658-34f09beeae56"",
                    ""path"": ""<Keyboard>/q"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Camera Rotation"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""51b0119e-c4eb-4dd1-bb6e-57ebb4b43f28"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Camera Rotation"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""53cc8910-8145-4c8c-9b44-c10906edb3a3"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Camera Center"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""ec32c19b-cb24-4717-819e-7823c09e8f38"",
                    ""path"": ""<Mouse>/scroll/y"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Camera Zoom"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""f66866fa-b464-4a28-a993-ccf7d2a6316b"",
                    ""path"": ""<Keyboard>/tab"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Inventory"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""0e674059-71c1-4639-96bf-3edacc01be0e"",
                    ""path"": ""<Keyboard>/i"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Equipment"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""ed6b9c23-6f07-4c02-bdbb-92d47b968d34"",
                    ""path"": ""<Keyboard>/f"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Interaction"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""UI"",
            ""id"": ""88984102-ab3d-496e-bb1f-56c14abe62f0"",
            ""actions"": [
                {
                    ""name"": ""New action"",
                    ""type"": ""Button"",
                    ""id"": ""5897d701-39cf-40cd-a8d7-fc59ceb90615"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""08f0779e-75b2-488f-a94c-18a566a2b313"",
                    ""path"": """",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""New action"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
            // Game
            m_Game = asset.FindActionMap("Game", throwIfNotFound: true);
            m_Game_MouseRightClick = m_Game.FindAction("MouseRightClick", throwIfNotFound: true);
            m_Game_ShiftHold = m_Game.FindAction("ShiftHold", throwIfNotFound: true);
            m_Game_CameraMovement = m_Game.FindAction("Camera Movement", throwIfNotFound: true);
            m_Game_CameraRotation = m_Game.FindAction("Camera Rotation", throwIfNotFound: true);
            m_Game_CameraCenter = m_Game.FindAction("Camera Center", throwIfNotFound: true);
            m_Game_CameraZoom = m_Game.FindAction("Camera Zoom", throwIfNotFound: true);
            m_Game_Inventory = m_Game.FindAction("Inventory", throwIfNotFound: true);
            m_Game_Equipment = m_Game.FindAction("Equipment", throwIfNotFound: true);
            m_Game_Interaction = m_Game.FindAction("Interaction", throwIfNotFound: true);
            // UI
            m_UI = asset.FindActionMap("UI", throwIfNotFound: true);
            m_UI_Newaction = m_UI.FindAction("New action", throwIfNotFound: true);
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

        // Game
        private readonly InputActionMap m_Game;
        private IGameActions m_GameActionsCallbackInterface;
        private readonly InputAction m_Game_MouseRightClick;
        private readonly InputAction m_Game_ShiftHold;
        private readonly InputAction m_Game_CameraMovement;
        private readonly InputAction m_Game_CameraRotation;
        private readonly InputAction m_Game_CameraCenter;
        private readonly InputAction m_Game_CameraZoom;
        private readonly InputAction m_Game_Inventory;
        private readonly InputAction m_Game_Equipment;
        private readonly InputAction m_Game_Interaction;
        public struct GameActions
        {
            private @PlayerControls m_Wrapper;
            public GameActions(@PlayerControls wrapper) { m_Wrapper = wrapper; }
            public InputAction @MouseRightClick => m_Wrapper.m_Game_MouseRightClick;
            public InputAction @ShiftHold => m_Wrapper.m_Game_ShiftHold;
            public InputAction @CameraMovement => m_Wrapper.m_Game_CameraMovement;
            public InputAction @CameraRotation => m_Wrapper.m_Game_CameraRotation;
            public InputAction @CameraCenter => m_Wrapper.m_Game_CameraCenter;
            public InputAction @CameraZoom => m_Wrapper.m_Game_CameraZoom;
            public InputAction @Inventory => m_Wrapper.m_Game_Inventory;
            public InputAction @Equipment => m_Wrapper.m_Game_Equipment;
            public InputAction @Interaction => m_Wrapper.m_Game_Interaction;
            public InputActionMap Get() { return m_Wrapper.m_Game; }
            public void Enable() { Get().Enable(); }
            public void Disable() { Get().Disable(); }
            public bool enabled => Get().enabled;
            public static implicit operator InputActionMap(GameActions set) { return set.Get(); }
            public void SetCallbacks(IGameActions instance)
            {
                if (m_Wrapper.m_GameActionsCallbackInterface != null)
                {
                    @MouseRightClick.started -= m_Wrapper.m_GameActionsCallbackInterface.OnMouseRightClick;
                    @MouseRightClick.performed -= m_Wrapper.m_GameActionsCallbackInterface.OnMouseRightClick;
                    @MouseRightClick.canceled -= m_Wrapper.m_GameActionsCallbackInterface.OnMouseRightClick;
                    @ShiftHold.started -= m_Wrapper.m_GameActionsCallbackInterface.OnShiftHold;
                    @ShiftHold.performed -= m_Wrapper.m_GameActionsCallbackInterface.OnShiftHold;
                    @ShiftHold.canceled -= m_Wrapper.m_GameActionsCallbackInterface.OnShiftHold;
                    @CameraMovement.started -= m_Wrapper.m_GameActionsCallbackInterface.OnCameraMovement;
                    @CameraMovement.performed -= m_Wrapper.m_GameActionsCallbackInterface.OnCameraMovement;
                    @CameraMovement.canceled -= m_Wrapper.m_GameActionsCallbackInterface.OnCameraMovement;
                    @CameraRotation.started -= m_Wrapper.m_GameActionsCallbackInterface.OnCameraRotation;
                    @CameraRotation.performed -= m_Wrapper.m_GameActionsCallbackInterface.OnCameraRotation;
                    @CameraRotation.canceled -= m_Wrapper.m_GameActionsCallbackInterface.OnCameraRotation;
                    @CameraCenter.started -= m_Wrapper.m_GameActionsCallbackInterface.OnCameraCenter;
                    @CameraCenter.performed -= m_Wrapper.m_GameActionsCallbackInterface.OnCameraCenter;
                    @CameraCenter.canceled -= m_Wrapper.m_GameActionsCallbackInterface.OnCameraCenter;
                    @CameraZoom.started -= m_Wrapper.m_GameActionsCallbackInterface.OnCameraZoom;
                    @CameraZoom.performed -= m_Wrapper.m_GameActionsCallbackInterface.OnCameraZoom;
                    @CameraZoom.canceled -= m_Wrapper.m_GameActionsCallbackInterface.OnCameraZoom;
                    @Inventory.started -= m_Wrapper.m_GameActionsCallbackInterface.OnInventory;
                    @Inventory.performed -= m_Wrapper.m_GameActionsCallbackInterface.OnInventory;
                    @Inventory.canceled -= m_Wrapper.m_GameActionsCallbackInterface.OnInventory;
                    @Equipment.started -= m_Wrapper.m_GameActionsCallbackInterface.OnEquipment;
                    @Equipment.performed -= m_Wrapper.m_GameActionsCallbackInterface.OnEquipment;
                    @Equipment.canceled -= m_Wrapper.m_GameActionsCallbackInterface.OnEquipment;
                    @Interaction.started -= m_Wrapper.m_GameActionsCallbackInterface.OnInteraction;
                    @Interaction.performed -= m_Wrapper.m_GameActionsCallbackInterface.OnInteraction;
                    @Interaction.canceled -= m_Wrapper.m_GameActionsCallbackInterface.OnInteraction;
                }
                m_Wrapper.m_GameActionsCallbackInterface = instance;
                if (instance != null)
                {
                    @MouseRightClick.started += instance.OnMouseRightClick;
                    @MouseRightClick.performed += instance.OnMouseRightClick;
                    @MouseRightClick.canceled += instance.OnMouseRightClick;
                    @ShiftHold.started += instance.OnShiftHold;
                    @ShiftHold.performed += instance.OnShiftHold;
                    @ShiftHold.canceled += instance.OnShiftHold;
                    @CameraMovement.started += instance.OnCameraMovement;
                    @CameraMovement.performed += instance.OnCameraMovement;
                    @CameraMovement.canceled += instance.OnCameraMovement;
                    @CameraRotation.started += instance.OnCameraRotation;
                    @CameraRotation.performed += instance.OnCameraRotation;
                    @CameraRotation.canceled += instance.OnCameraRotation;
                    @CameraCenter.started += instance.OnCameraCenter;
                    @CameraCenter.performed += instance.OnCameraCenter;
                    @CameraCenter.canceled += instance.OnCameraCenter;
                    @CameraZoom.started += instance.OnCameraZoom;
                    @CameraZoom.performed += instance.OnCameraZoom;
                    @CameraZoom.canceled += instance.OnCameraZoom;
                    @Inventory.started += instance.OnInventory;
                    @Inventory.performed += instance.OnInventory;
                    @Inventory.canceled += instance.OnInventory;
                    @Equipment.started += instance.OnEquipment;
                    @Equipment.performed += instance.OnEquipment;
                    @Equipment.canceled += instance.OnEquipment;
                    @Interaction.started += instance.OnInteraction;
                    @Interaction.performed += instance.OnInteraction;
                    @Interaction.canceled += instance.OnInteraction;
                }
            }
        }
        public GameActions @Game => new GameActions(this);

        // UI
        private readonly InputActionMap m_UI;
        private IUIActions m_UIActionsCallbackInterface;
        private readonly InputAction m_UI_Newaction;
        public struct UIActions
        {
            private @PlayerControls m_Wrapper;
            public UIActions(@PlayerControls wrapper) { m_Wrapper = wrapper; }
            public InputAction @Newaction => m_Wrapper.m_UI_Newaction;
            public InputActionMap Get() { return m_Wrapper.m_UI; }
            public void Enable() { Get().Enable(); }
            public void Disable() { Get().Disable(); }
            public bool enabled => Get().enabled;
            public static implicit operator InputActionMap(UIActions set) { return set.Get(); }
            public void SetCallbacks(IUIActions instance)
            {
                if (m_Wrapper.m_UIActionsCallbackInterface != null)
                {
                    @Newaction.started -= m_Wrapper.m_UIActionsCallbackInterface.OnNewaction;
                    @Newaction.performed -= m_Wrapper.m_UIActionsCallbackInterface.OnNewaction;
                    @Newaction.canceled -= m_Wrapper.m_UIActionsCallbackInterface.OnNewaction;
                }
                m_Wrapper.m_UIActionsCallbackInterface = instance;
                if (instance != null)
                {
                    @Newaction.started += instance.OnNewaction;
                    @Newaction.performed += instance.OnNewaction;
                    @Newaction.canceled += instance.OnNewaction;
                }
            }
        }
        public UIActions @UI => new UIActions(this);
        public interface IGameActions
        {
            void OnMouseRightClick(InputAction.CallbackContext context);
            void OnShiftHold(InputAction.CallbackContext context);
            void OnCameraMovement(InputAction.CallbackContext context);
            void OnCameraRotation(InputAction.CallbackContext context);
            void OnCameraCenter(InputAction.CallbackContext context);
            void OnCameraZoom(InputAction.CallbackContext context);
            void OnInventory(InputAction.CallbackContext context);
            void OnEquipment(InputAction.CallbackContext context);
            void OnInteraction(InputAction.CallbackContext context);
        }
        public interface IUIActions
        {
            void OnNewaction(InputAction.CallbackContext context);
        }
    }
}
