using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.InputSystem;

namespace TSGameDev.Controls.PlayerStates
{
    public enum PlayerStates
    {
        Idle,
        Walking,
        Running
    }

    public class PlayerState
    {
        protected PlayerStates previousStateCache;
        protected Player player;
        protected NavMeshAgent agent;
        protected Animator anim;

        public PlayerState(Player player)
        {
            this.player = player;
            agent = player.GetComponent<NavMeshAgent>();
            anim = player.GetComponent<Animator>();
        }

        public virtual void Update()
        {

        }

        public virtual void StateTransition(PlayerStates TransitionState, PlayerStates ToBePreviousState)
        {
            switch(TransitionState)
            {
                case PlayerStates.Idle:
                    player.state = new PlayerStateIdle(player);
                    break;
                case PlayerStates.Walking:
                    player.state = new PlayerStateWalking(player);
                    break;
                case PlayerStates.Running:
                    player.state = new PlayerStateRunning(player);
                    break;
            }
            previousStateCache = ToBePreviousState;
        }

        public virtual void MoveTo()
        {
            Ray ray = Camera.main.ScreenPointToRay(Mouse.current.position.ReadValue());
            if (Physics.Raycast(ray, out RaycastHit hit))
            {
                if (agent.hasPath)
                    agent.ResetPath();

                agent.SetDestination(hit.point);
                player.gameObject.transform.LookAt(hit.point);
            }
        }
    }
}
