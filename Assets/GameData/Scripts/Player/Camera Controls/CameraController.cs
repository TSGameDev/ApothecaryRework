using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TSGameDev.Controls.Camera
{
    public class CameraController : MonoBehaviour
    {
        [SerializeField] CameraConnector cameraConnector;
        public Transform cameraTranform;
        public Transform playerTransform;

        private void Start()
        {
            cameraConnector.newPos = transform.position;
            cameraConnector.newRot = transform.rotation;
            cameraConnector.newZoom = cameraTranform.localPosition;
        }

        private void Update()
        {
            HandleMovementInput();
            HandleRotation();
            HandleZoom();
        }

        /// <summary>
        /// Function that handles the movement of the camera via the WASD keys
        /// </summary>
        void HandleMovementInput()
        {
            //Use fast speed if the shift key is down
            if (cameraConnector.fastMode)
                cameraConnector.currentSpeed = cameraConnector.fastSpeed;
            else
                cameraConnector.currentSpeed = cameraConnector.normalSpeed;

            //Right
            if (cameraConnector.cameraInput.x >= 0.5f)
            {
                cameraConnector.newPos += (transform.right * cameraConnector.currentSpeed);
            }

            //Left
            else if (cameraConnector.cameraInput.x <= -0.5f)
            {
                cameraConnector.newPos += (transform.right * -cameraConnector.currentSpeed);
            }

            //Forward
            if (cameraConnector.cameraInput.y >= 0.5f)
            {
                cameraConnector.newPos += (transform.forward * cameraConnector.currentSpeed);
            }

            //Backward
            else if (cameraConnector.cameraInput.y <= -0.5f)
            {
                cameraConnector.newPos += (transform.forward * -cameraConnector.currentSpeed);
            }

            if (cameraConnector.lockCamera)
            {
                Vector3 playerPos = playerTransform.position;
                playerPos.y = gameObject.transform.position.y;
                cameraConnector.newPos = playerPos;
            }

            transform.position = Vector3.Lerp(transform.position, cameraConnector.newPos, Time.deltaTime * cameraConnector.movementLerpTime);
        }

        /// <summary>
        /// Function that handles the rotation of the camera via the QE keys
        /// </summary>
        void HandleRotation()
        {
            //Rotate Clockwise
            if (cameraConnector.rotateCameraRight)
            {
                cameraConnector.newRot *= Quaternion.Euler(Vector3.up * cameraConnector.rotationTickAmount);
            }
            //Rotate anti-Clockwise
            else if (cameraConnector.rotateCameraLeft)
            {
                cameraConnector.newRot *= Quaternion.Euler(Vector3.up * -cameraConnector.rotationTickAmount);
            }
            transform.rotation = Quaternion.Lerp(transform.rotation, cameraConnector.newRot, Time.deltaTime * cameraConnector.movementLerpTime);
        }

        /// <summary>
        /// Function that handles the zooming of the camera via the mouse scroll wheel
        /// </summary>
        void HandleZoom()
        {
            if (cameraConnector.zoomCameraIn)
            {
                cameraConnector.newZoom -= cameraConnector.zoomTickAmount;
            }
            else if (cameraConnector.zoomCameraOut)
            {
                cameraConnector.newZoom += cameraConnector.zoomTickAmount;
            }

            if (cameraConnector.newZoom.y <= 10 || cameraConnector.newZoom.z >= -10)
            {
                cameraConnector.newZoom = new Vector3(0, 10, -10);
            }
            cameraTranform.localPosition = Vector3.Lerp(cameraTranform.localPosition, cameraConnector.newZoom, Time.deltaTime * cameraConnector.movementLerpTime);
        }
    }
}
