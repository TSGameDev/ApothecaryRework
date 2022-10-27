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
            Debug.Log(reagentItem);
            string knownEffectBuilder = $"Known Effects: {Environment.NewLine} ";
            List<IngredientEffects> itemEffects = reagentItem.GetReagentEffects();
            Debug.Log(itemEffects.Count);
            foreach(IngredientEffects ingredientEffect in itemEffects)
            {
                string keyEffectName = Enum.GetName(typeof(Effects), ingredientEffect.effect);
                string EffectTier = ingredientEffect.effectTier.ToString();

                knownEffectBuilder += $"{keyEffectName} {EffectTier} {Environment.NewLine}";
            }
            return knownEffectBuilder;
        }

        private string ReagentProcessingSetup(ReagentItem reagentItem)
        {
            string knownProcessBuilder = $"Known Processes: {Environment.NewLine}";
            knownProcessBuilder += MortarProcessingSetup(reagentItem);
            knownProcessBuilder += BlenderProcessingSetup(reagentItem);
            knownProcessBuilder += JuicerProcessingSetup(reagentItem);
            knownProcessBuilder += ChoppingProcessingSetup(reagentItem);
            knownProcessBuilder += BunsenProcessingSetup(reagentItem);
            return knownProcessBuilder;
        }

        private string MortarProcessingSetup(ReagentItem reagentItem)
        {
            string stringBuilder = "";
            InventoryItem MortarResult = reagentItem.GetMortarPrimaryResult();
            if (MortarResult != null)
            {
                stringBuilder += $"Mortar: {MortarResult.GetDisplayName()}, ";
                InventoryItem MortarSecResult = reagentItem.GetMortarSecondaryResult();
                if (MortarSecResult != null)
                {
                    stringBuilder += $"{MortarSecResult.GetDisplayName()} {Environment.NewLine}";
                }
            }
            return stringBuilder;
        }

        private string BlenderProcessingSetup(ReagentItem reagentItem)
        {
            string stringBuilder = "";
            InventoryItem BlenderResult = reagentItem.GetBlendingResult();
            if (BlenderResult != null)
            {
                stringBuilder += $"Blender: {BlenderResult.GetDisplayName()} {Environment.NewLine}";
            }
            return stringBuilder;
        }

        private string JuicerProcessingSetup(ReagentItem reagentItem)
        {
            string stringBuilder = "";
            InventoryItem JuicerResult = reagentItem.GetJuicerPrimaryResult();
            if (JuicerResult != null)
            {
                stringBuilder += $"Juicer: {JuicerResult.GetDisplayName()}, ";
                InventoryItem JuicerSecResult = reagentItem.GetJuicerSecondaryResult();
                if (JuicerSecResult != null)
                {
                    stringBuilder += $"{JuicerSecResult.GetDisplayName()} {Environment.NewLine}";
                }
            }
            return stringBuilder;
        }

        private string ChoppingProcessingSetup(ReagentItem reagentItem)
        {
            string stringBuilder = "";
            InventoryItem ChoppingResult = reagentItem.GetChoppingPrimaryResult();
            if (ChoppingResult != null)
            {
                stringBuilder += $"Juicer: {ChoppingResult.GetDisplayName()}, ";
                InventoryItem ChoppingSecResult = reagentItem.GetChoppingSecondaryResult();
                if (ChoppingSecResult != null)
                {
                    stringBuilder += $"{ChoppingSecResult.GetDisplayName()} {Environment.NewLine}";
                }
            }
            return stringBuilder;
        }

        private string BunsenProcessingSetup(ReagentItem reagentItem)
        {
            string stringBuilder = "";
            List<BunsenBurnerProcess> BunsenResult = reagentItem.GetBunsenBurnerProcesses();
            if (BunsenResult != null)
            {
                stringBuilder += $"Bunsen: ";
                foreach (BunsenBurnerProcess process in BunsenResult)
                {
                    stringBuilder += $"{process.minTemp} - {process.maxTemp} = {process.result.GetDisplayName()}, ";
                }
            }
            return stringBuilder;
        }

        #endregion
    }
}
