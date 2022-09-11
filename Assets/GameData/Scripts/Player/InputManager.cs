using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TSGameDev.Controls
{
    public class InputManager : MonoBehaviour
    {
        #region Private Variables

        Player player;
        PlayerControls playerControls;

        #endregion

        private void OnEnable()
        {
            player = GetComponent<Player>();

            if (playerControls == null)
                playerControls = new();

            playerControls.Enable();
            playerControls.Game.Enable();

            playerControls.Game.MouseRightClick.performed += ctx => player.state.MoveTo();
            playerControls.Game.ShiftHold.performed += ctx => player.isRunning = !player.isRunning;
        }

        private void OnDisable()
        {
            playerControls.Disable();
        }
    }
}
