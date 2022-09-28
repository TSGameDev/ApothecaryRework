using TSGameDev.SavingSystem;
using UnityEngine;
using CodeMonkey.Utils;
using TSGameDev.Controls.MainPlayer;

namespace TSGameDev.Inventories.Pickups
{
    public class PickupMultiSpawner : MonoBehaviour, ISaveable
    {
        #region Serialized Variables

        [SerializeField] PlayerConnector playerConnector;
        [SerializeField] InventoryItem item;
        [SerializeField] int minItemAmount = 1;
        [SerializeField] int maxItemAmount = 2;
        [SerializeField] float respawnTime = 1f;

        #endregion

        #region Private Variables

        int selectedItemAmount = 0;

        #endregion

        #region Life Cycle Functions

        private void Awake()
        {
            // Spawn in Awake so can be destroyed by save system after.
            SpawnPickup();
        }

        #endregion

        #region Public Functions

        /// <summary>
        /// Returns the pickup spawned by this class if it exists.
        /// </summary>
        /// <returns>Returns null if the pickup has been collected.</returns>
        public Pickup GetPickup()
        {
            return GetComponentInChildren<Pickup>();
        }

        /// <summary>
        /// True if the pickup was collected.
        /// </summary>
        public bool isCollected()
        {
            return GetPickup() == null;
        }

        public int SelectItemAmount()
        {
            if (selectedItemAmount == 0)
                selectedItemAmount = Random.Range(minItemAmount, maxItemAmount);

            return selectedItemAmount;
        }

        public void BeginSpawnerTimer()
        {
            FunctionTimer.Create(SpawnPickup, respawnTime);
        }

        #endregion

        #region Private Functions

        /// <summary>
        /// Function that collects the pickup prefab from the item variable and spawns it as a child to this spawner and this spawners location.
        /// </summary>
        private void SpawnPickup()
        {
            var spawnedPickup = item.SpawnPickup(transform.position, SelectItemAmount());
            spawnedPickup.transform.SetParent(transform);
            selectedItemAmount = 0;
        }

        /// <summary>
        /// Destorys the child spawned pickup
        /// </summary>
        private void DestroyPickup()
        {
            if (GetPickup())
            {
                Destroy(GetPickup().gameObject);
            }
        }

        private void OnTriggerEnter(Collider other)
        {
            if(other.CompareTag("Player") && GetPickup())
            {
                Pickup pickup = GetPickup();
                if (pickup.CanBePickedUp())
                {
                    playerConnector.playerInteraction = pickup.PickupItem;
                }
            }
        }

        /// <summary>
        /// Function implimented by ISavable allows for this script to define saving functionlaity
        /// </summary>
        /// <returns>
        /// An object which is the spawned pickup gameobject if it is there.
        /// </returns>
        object ISaveable.CaptureState()
        {
            return null;
        }

        /// <summary>
        /// Function implimented by ISavable allows for this script to define the functionlaity of loading save data.
        /// </summary>
        /// <param name="state">
        /// A bool for if this pickup was collected or not. If so then it destorys the awake spawned pickup.
        /// </param>
        void ISaveable.RestoreState(object state)
        {

        }

        #endregion

    }
}
