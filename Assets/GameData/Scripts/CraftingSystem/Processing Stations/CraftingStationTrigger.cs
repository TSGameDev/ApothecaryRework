using TSGameDev.Controls.MainPlayer;
using UnityEngine;


 public class CraftingStationTrigger: MonoBehaviour
 {
    [SerializeField] PlayerConnector playerConnector;
    [SerializeField] GameObject craftingStation;

    private void OpenCraftingStation()
    {
        craftingStation.SetActive(!craftingStation.activeSelf);
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            playerConnector.playerInteraction = OpenCraftingStation;
        }
    }
}

