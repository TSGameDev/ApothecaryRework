using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;

namespace TSGameDev.Controls.PlayerStates
{
    public class PlayerStateWalking : PlayerState
    {
        public PlayerStateWalking(Player player) : base(player) { SetWalking(); }

        public override void MoveTo()
        {
            base.MoveTo();

            if (player.isRunning)
                StateTransition(PlayerStates.Running, PlayerStates.Walking);
        }

        public override void Update()
        {
            CheckDestination();
        }

        private async void SetWalking()
        {
            while(anim.GetFloat(player.animSpeed) < 1)
            {
                float lerpSpeed = Mathf.Lerp(0, 1, 0.1f);
                anim.SetFloat(player.animSpeed, lerpSpeed);
            }
            await Task.Yield();
        }

        private void CheckDestination()
        {
            float remainingDis = Vector3.Distance(player.transform.position, agent.destination);
            if(remainingDis <= 0.5f)
            {
                StateTransition(PlayerStates.Idle, PlayerStates.Walking);

            }
        }
    }
}
