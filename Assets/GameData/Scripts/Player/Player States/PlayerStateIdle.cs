using UnityEngine;

namespace TSGameDev.Controls.PlayerStates
{
    public class PlayerStateIdle : PlayerState
    {
        public PlayerStateIdle(Player player) : base(player) { }

        public override void MoveTo()
        {
            base.MoveTo();

            if (player.isRunning)
                StateTransition(PlayerStates.Running, PlayerStates.Idle);
            else
                StateTransition(PlayerStates.Walking, PlayerStates.Idle);
        }

        public override void Update()
        {
            if (anim.GetFloat(player.animSpeed) > Mathf.Epsilon)
                anim.SetFloat(player.animSpeed, 0, 0.1f, 0.1f);
        }
    }
}
