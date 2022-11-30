using UnityEngine;

namespace TSGameDev.Controls.MainPlayer
{
    public interface IInteractable
    {
        /// <summary>
        /// Function that contains the functionality when the player interacts with this object.
        /// </summary>
        public void OnInteract();
    }
}
