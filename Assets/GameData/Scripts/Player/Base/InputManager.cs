using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TSGameDev.Controls.Camera;
using TSGameDev.Controls.MainPlayer;
using TSGameDev.UI.Controls;

namespace TSGameDev.Controls
{
    public class InputManager : MonoBehaviour
    {
        #region Player Variables

        Player player;
        PlayerControls playerControls;

        #endregion

        #region Camera Variables

        [SerializeField] CameraConnector cameraConnector;
        [SerializeField] PlayerConnector playerConnector;
        [SerializeField] UIConnector uiConnector;

        #endregion

        private void OnEnable()
        {
            player = GetComponent<Player>();

            if (playerControls == null)
                playerControls = new();

            playerControls.Enable();
            playerControls.Game.Enable();

            #region Movement Controls

            playerControls.Game.MouseRightClick.performed += ctx => player.state.MoveTo();

            playerControls.Game.ShiftHold.performed += ctx => player.isRunning = !player.isRunning;
            playerControls.Game.ShiftHold.performed += ctx => cameraConnector.fastMode = !cameraConnector.fastMode;

            #endregion

            #region Camera Controls

            playerControls.Game.CameraMovement.performed += ctx => cameraConnector.cameraInput = ctx.ReadValue<Vector2>();
            playerControls.Game.CameraMovement.canceled += ctx => cameraConnector.cameraInput = new Vector2();

            playerControls.Game.CameraRotation.performed += ctx =>
            {
                float rotationValue = ctx.ReadValue<float>();
                if (rotationValue >= 0.5f)
                {
                    cameraConnector.rotateCameraRight = true;
                    cameraConnector.rotateCameraLeft = false;
                }
                else if (rotationValue <= -0.5f)
                {
                    cameraConnector.rotateCameraLeft = true;
                    cameraConnector.rotateCameraRight = false;
                }
            };
            playerControls.Game.CameraRotation.canceled += ctx =>
            {
                cameraConnector.rotateCameraLeft = false;
                cameraConnector.rotateCameraRight = false;
            };

            playerControls.Game.CameraZoom.performed += ctx =>
            {
                float zoomValue = ctx.ReadValue<float>();
                if (zoomValue > 1)
                {
                    cameraConnector.zoomCameraIn = true;
                    cameraConnector.zoomCameraOut = false;
                }

                else if (zoomValue < -1)
                {
                    cameraConnector.zoomCameraIn = false;
                    cameraConnector.zoomCameraOut = true;
                }
            };
            playerControls.Game.CameraZoom.canceled += ctx =>
            {
                cameraConnector.zoomCameraIn = false;
                cameraConnector.zoomCameraOut = false;
            };

            playerControls.Game.CameraCenter.performed += ctx => cameraConnector.lockCamera = !cameraConnector.lockCamera;

            #endregion

            #region Interface Controls

            playerControls.Game.Inventory.performed += ctx => uiConnector.InventoryTween();
            playerControls.Game.Equipment.performed += ctx => uiConnector.EquipmentTween();

            #endregion

            #region Gameplay Controls

            playerControls.Game.Interaction.performed += ctx => playerConnector.playerInteraction();

            #endregion

        }

        private void OnDisable()
        {
            playerControls.Disable();
        }
    }
}
