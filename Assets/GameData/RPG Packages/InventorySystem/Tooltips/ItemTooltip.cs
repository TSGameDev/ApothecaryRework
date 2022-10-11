using System;
using UnityEngine;
using TMPro;
using TSGameDev.Inventories;
using UnityEngine.UI;
using System.Collections.Generic;

namespace TSGameDev.Inventories.ToolTips
{
    /// <summary>
    /// Root of the tooltip prefab to expose properties to other classes.
    /// </summary>
    public class ItemTooltip : MonoBehaviour
    {
        #region Serialized Variables

        [SerializeField] TextMeshProUGUI title;
        [SerializeField] Image itemIcon;
        [SerializeField] TextMeshProUGUI description;
        [SerializeField] TextMeshProUGUI itemType;
        [SerializeField] TextMeshProUGUI itemTier;
        [SerializeField] TextMeshProUGUI minPriceBronze;
        [SerializeField] TextMeshProUGUI maxPriceBronze;
        [SerializeField] TextMeshProUGUI minPriceSilver;
        [SerializeField] TextMeshProUGUI maxPriceSilver;
        [SerializeField] TextMeshProUGUI minPriceGold;
        [SerializeField] TextMeshProUGUI maxPriceGold;
        [SerializeField] TextMeshProUGUI knownEffects;
        [SerializeField] TextMeshProUGUI knownProcesses;


        #endregion

        #region Public Functions

        public void Setup(InventoryItem item)
        {
            GeneralSetup(item);

            ReagentItem reagentItem = item as ReagentItem;
            ReagentSetup(reagentItem);
        }

        private void GeneralSetup(InventoryItem item)
        {
            title.text = item.GetDisplayName();

            description.text = item.GetDescription();

            itemIcon.sprite = item.GetIcon();

            ItemTier Tier = item.GetTier();
            itemTier.text = $"{Enum.GetName(typeof(ItemTier), Tier)} Class Item";

            CurrencySet MinPrice = item.GetMinPrice();
            minPriceBronze.text = MinPrice.bronze.ToString();
            minPriceSilver.text = MinPrice.silver.ToString();
            minPriceGold.text = MinPrice.gold.ToString();

            CurrencySet MaxPrice = item.GetMaxPrice();
            maxPriceBronze.text = MaxPrice.bronze.ToString();
            maxPriceSilver.text = MaxPrice.silver.ToString();
            maxPriceGold.text = MaxPrice.gold.ToString();
        }

        private void ReagentSetup(ReagentItem reagentItem)
        {
            if (reagentItem == null)
                return;

            itemType.text = "Reagent Ingredient";

            knownEffects.text = ReagentEffectSetup(reagentItem);
            knownProcesses.text = ReagentProcessingSetup(reagentItem);
        }

        private string ReagentEffectSetup(ReagentItem reagentItem)
        {
            string knownEffectBuilder = $"Known Effects: {Environment.NewLine} ";

            foreach (KeyValuePair<Effects, int> ingredientEffect in reagentItem.GetReagentEffects())
            {
                string keyEffectName = Enum.GetName(typeof(Effects), ingredientEffect.Key);
                string EffectTier = ingredientEffect.Value.ToString();

                knownEffectBuilder += $"{keyEffectName} {EffectTier} {Environment.NewLine}";
            }
            return knownEffectBuilder;
        }

        private string ReagentProcessingSetup(ReagentItem reagentItem)
        {
            string knownProcessBuilder = $"Known Processes: {Environment.NewLine}";
            MortarProcessingSetup(reagentItem, knownProcessBuilder);
            BlenderProcessingSetup(reagentItem, knownProcessBuilder);
            JuicerProcessingSetup(reagentItem, knownProcessBuilder);
            ChoppingProcessingSetup(reagentItem, knownProcessBuilder);
            BunsenProcessingSetup(reagentItem, knownProcessBuilder);
            return knownProcessBuilder;
        }

        private void MortarProcessingSetup(ReagentItem reagentItem, string knownProcessBuilder)
        {
            InventoryItem MortarResult = reagentItem.GetMortarPrimaryResult();
            if (MortarResult != null)
            {
                knownProcessBuilder += $"Mortar: {MortarResult.GetDisplayName()}, ";
                InventoryItem MortarSecResult = reagentItem.GetMortarSecondaryResult();
                if (MortarSecResult != null)
                {
                    knownProcessBuilder += $"{MortarSecResult.GetDisplayName()} {Environment.NewLine}";
                }
            }
        }

        private void BlenderProcessingSetup(ReagentItem reagentItem, string knownProcessBuilder)
        {
            InventoryItem BlenderResult = reagentItem.GetBlendingResult();
            if (BlenderResult != null)
            {
                knownProcessBuilder += $"Blender: {BlenderResult.GetDisplayName()} {Environment.NewLine}";
            }
        }

        private void JuicerProcessingSetup(ReagentItem reagentItem, string knownProcessBuilder)
        {
            InventoryItem JuicerResult = reagentItem.GetJuicerPrimaryResult();
            if (JuicerResult != null)
            {
                knownProcessBuilder += $"Juicer: {JuicerResult.GetDisplayName()}, ";
                InventoryItem JuicerSecResult = reagentItem.GetJuicerSecondaryResult();
                if (JuicerSecResult != null)
                {
                    knownProcessBuilder += $"{JuicerSecResult.GetDisplayName()} {Environment.NewLine}";
                }
            }
        }

        private void ChoppingProcessingSetup(ReagentItem reagentItem, string knownProcessBuilder)
        {
            InventoryItem ChoppingResult = reagentItem.GetChoppingPrimaryResult();
            if (ChoppingResult != null)
            {
                knownProcessBuilder += $"Juicer: {ChoppingResult.GetDisplayName()}, ";
                InventoryItem ChoppingSecResult = reagentItem.GetChoppingSecondaryResult();
                if (ChoppingSecResult != null)
                {
                    knownProcessBuilder += $"{ChoppingSecResult.GetDisplayName()} {Environment.NewLine}";
                }
            }
        }

        private void BunsenProcessingSetup(ReagentItem reagentItem, string knownProcessBuilder)
        {
            List<BunsenBurnerProcess> BunsenResult = reagentItem.GetBunsenBurnerProcesses();
            if (BunsenResult != null)
            {
                knownProcessBuilder += $"Bunsen: ";
                foreach (BunsenBurnerProcess process in BunsenResult)
                {
                    knownProcessBuilder += $"{process.minTemp} - {process.maxTemp} = {process.result.GetDisplayName()}, ";
                }
            }
        }

        #endregion
    }
}
