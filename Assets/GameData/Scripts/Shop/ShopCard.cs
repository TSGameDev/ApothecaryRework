using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using TSGameDev.Inventories;
using static TSGameDev.Inventories.Inventory;

namespace TSGameDev.Core.Shop
{
    [Serializable]
    enum CardType
    {
        BuyCard,
        SellCard,
        BuyBackCard,
        QuotaCard,
    }

    public class ShopCard : MonoBehaviour, ICard
    {
        [SerializeField] CardType cardType;
        [SerializeField] Image itemImage;
        [SerializeField] TextMeshProUGUI itemName, itemPriceDisplay, itemAmount;
        [SerializeField] Inventory playerInventory, shopInventory;
        
        private int _InventorySlotCache;
        private Button _InteractionButton;

        public void Initialisation(InventorySlot slot, int slotIndex)
        {
            #region General Shop Card Functionality

            if (_InteractionButton == null)
                _InteractionButton = GetComponent<Button>();
            _InteractionButton.onClick.RemoveAllListeners();

            gameObject.SetActive(true);
            _InventorySlotCache = slotIndex;

            itemImage.sprite = slot.item.GetIcon();
            itemName.text = slot.item.name;
            itemAmount.text = slot.number.ToString();

            #endregion

            switch(cardType)
            {
                case CardType.BuyCard:
                    CurrencySet itemPriceBuy = slot.item.GetMaxPrice();
                    itemPriceDisplay.text = $"Bronze: {itemPriceBuy.bronze} Siler: {itemPriceBuy.silver} Gold: {itemPriceBuy.gold}";
                    _InteractionButton.onClick.AddListener(() => 
                    {
                        BuyCard(slot, slotIndex);
                    });
                    break;
                case CardType.SellCard:
                    CurrencySet itemPriceSell = slot.item.GetMinPrice();
                    itemPriceDisplay.text = $"Bronze: {itemPriceSell.bronze} Siler: {itemPriceSell.silver} Gold: {itemPriceSell.gold}";
                    _InteractionButton.onClick.AddListener(() =>
                    {
                        SellCard(slot, slotIndex);
                    });
                    break;
                case CardType.BuyBackCard:
                    CurrencySet itemPriceBuyBack = slot.item.GetMaxPrice();
                    itemPriceDisplay.text = $"Bronze: {itemPriceBuyBack.bronze} Siler: {itemPriceBuyBack.silver} Gold: {itemPriceBuyBack.gold}";
                    _InteractionButton.onClick.AddListener(() =>
                    {
                        BuyBackCard(slot, slotIndex);
                    });
                    break;
                case CardType.QuotaCard:
                    CurrencySet itemPriceQuota = slot.item.GetMaxPrice();
                    itemPriceDisplay.text = $"Bronze: {itemPriceQuota.bronze} Siler: {itemPriceQuota.silver} Gold: {itemPriceQuota.gold}";
                    _InteractionButton.onClick.AddListener(() =>
                    {
                        QuotaCard(slot, slotIndex);
                    });
                    break;

            }

        }

        private void BuyCard(InventorySlot slot, int slotIndex)
        {
            playerInventory.AddToFirstEmptySlot(slot.item, 1);
            //remove currency from player
            shopInventory.RemoveItem(slot.item, 1);
        }

        private void SellCard(InventorySlot slot, int slotIndex)
        {
            playerInventory.RemoveItem(slot.item, 1);
            //Add Curency to player
            shopInventory.AddToFirstEmptySlot(slot.item, 1);
        }

        private void BuyBackCard(InventorySlot slot, int slotIndex)
        {
            playerInventory.AddToFirstEmptySlot(slot.item, 1);
            //remove currenct from player
            shopInventory.RemoveItem(slot.item, 1);
        }

        private void QuotaCard(InventorySlot slot, int slotIndex)
        {
            playerInventory.RemoveItem(slot.item, 1);
            shopInventory.RemoveItem(slot.item, 1);
            //Add currency to player
        }
    }
}
