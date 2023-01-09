using System.Collections.Generic;
using UnityEngine;
using TSGameDev.Inventories;

namespace TSGameDev.Core.Shop
{
    //Script to be placed on a shop tab to indicate what can be bought or sold to this specific section
    public class Shop : MonoBehaviour
    {
        [Tooltip("The specific tabs inventory, either items to buy or the items that can be sold to the shop.")]
        [SerializeField] Inventory shopInventory;
        [Tooltip("The item card to be used for items in this shop section. The card determines functionality liek buying selling buying back and the currency used.")]
        [SerializeField] GameObject shopCard;
        [Tooltip("The parent for all the shopcards.")]
        [SerializeField] Transform content;

        //Cache for all the created shopcards. An object pool.
        private List<GameObject> _ShopCardCache = new();

        private void Awake()
        {
            //Create to shop when enabled and then assign the creation function to the event called on the inventories update event.
            UpdateShopCards();
            shopInventory.InventoryUpdated += UpdateShopCards;
        }

        //Function to create and update all the cards within the shop to correctly display inventory data.
        private void UpdateShopCards() => CardSpawner.UpdateCards(_ShopCardCache, shopInventory.GetInventory(), shopCard, content);
    }
}
