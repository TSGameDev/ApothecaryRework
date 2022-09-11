using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TSGameDev.Controls.PlayerStates
{
    public class PlayerStateRunning : PlayerState
    {
        public PlayerStateRunning(Player player) : base(player) {  }

        public override void Update()
        {
            if (anim.GetFloat(player.animSpeed) < 2)
                anim.SetFloat(player.animSpeed, 2, 0.05f, 0.1f);

            CheckDestination();
        }

        public override void MoveTo()
        {
            base.MoveTo();

            if (player.isRunning)
                StateTransition(PlayerStates.Walking, PlayerStates.Running);
        }

        private void CheckDestination()
        {
            float remainingDis = Vector3.Distance(player.transform.position, agent.destination);
            if (remainingDis <= 0.5f)
            {
                StateTransition(PlayerStates.Idle, PlayerStates.Walking);

            }
        }
    }
}
