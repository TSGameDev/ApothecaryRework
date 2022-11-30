using TSGameDev.Controls.MainPlayer;
using UnityEngine;

namespace TSGameDev.Inventories.Crafting
{
    public class CraftingStationTrigger : MonoBehaviour, IInteractable
    {
        [SerializeField] PlayerConnector playerConnector;
        [SerializeField] GameObject craftingStation;

        public void OnInteract() => craftingStation.SetActive(!craftingStation.activeSelf);
    }
}

