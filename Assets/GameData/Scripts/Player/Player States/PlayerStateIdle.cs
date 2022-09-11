using UnityEngine;

namespace TSGameDev.Controls.PlayerStates
{
    public class PlayerStateIdle : PlayerState
    {
        public PlayerStateIdle(Player player) : base(player) { SetupIdle(); }

        public override void MoveTo()
        {
            base.MoveTo();

            if (player.isRunning)
                StateTransition(PlayerStates.Running, PlayerStates.Idle);
            else
                StateTransition(PlayerStates.Walking, PlayerStates.Idle);
        }

        private void SetupIdle()
        {
            if (previousStateCache == PlayerStates.Walking)
                anim.SetFloat(player.animSpeed, Mathf.Lerp(1, 0, 1));
            else
                anim.SetFloat(player.animSpeed, Mathf.Lerp(2, 0, 1));
        }
    }
}
