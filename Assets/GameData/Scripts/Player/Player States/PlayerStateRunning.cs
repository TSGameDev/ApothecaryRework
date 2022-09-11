using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TSGameDev.Controls.PlayerStates
{
    public class PlayerStateRunning : PlayerState
    {
        public PlayerStateRunning(Player player) : base(player) { SetRunning(); }

        public override void MoveTo()
        {
            base.MoveTo();

            if (player.isRunning)
                StateTransition(PlayerStates.Walking, PlayerStates.Running);
        }

        private void SetRunning()
        {
            if (previousStateCache == PlayerStates.Walking)
                anim.SetFloat(player.animSpeed, Mathf.Lerp(1, 2, 1));
            else
                anim.SetFloat(player.animSpeed, Mathf.Lerp(0f, 2f, 1));
        }
    }
}
