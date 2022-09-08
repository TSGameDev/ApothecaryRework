using UnityEngine;
using UnityEngine.AI;
using UnityEngine.InputSystem;

namespace TSGameDev.Controls
{
    [RequireComponent(typeof(InputManager))]
    public class Player : MonoBehaviour
    {
        #region Movement Variables

        NavMeshAgent agent;

        #endregion

        #region Lifecycle Functions

        private void Awake()
        {
            agent = GetComponent<NavMeshAgent>();
        }

        #endregion

        #region Public Functions

        public void MoveTo()
        {
            Ray ray = Camera.main.ScreenPointToRay(Mouse.current.position.ReadValue());
            if (Physics.Raycast(ray, out RaycastHit hit))
            {
                if (agent.hasPath)
                    agent.ResetPath();

                agent.SetDestination(hit.point);
            }
        }

        #endregion
    }
}
