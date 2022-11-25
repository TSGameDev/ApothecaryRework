using UnityEngine;
using TSGameDev.Inventories.Actions;
using System.Collections.Generic;
using Sirenix.OdinInspector;
using System;

namespace TSGameDev.Inventories
{
    [Serializable]
    public struct PotionRecipe
    {
        public BaseItem baseItem;
        public ReagentItem reagentItemPrimary;
        public ReagentItem reagentItemSecondary;

        public PotionRecipe(BaseItem baseItem, ReagentItem reagentItemPrimary, ReagentItem reagentItemSecondary)
        {
            this.baseItem = baseItem;
            this.reagentItemPrimary = reagentItemPrimary;
            this.reagentItemSecondary = reagentItemSecondary;
        }
    }

    [CreateAssetMenu(menuName = "TSGameDev/Inventory/New Potion Item")]
    public class PotionItem : ActionItem
    {
        #region Serialised Base Variables

        [TabGroup("Tab1", "Base Information")]
        [PropertyTooltip("A list of all the effect this ingredient provides to the potions it creates")]
        [SerializeField] List<BaseAlchemicalEffects> positiveAlchemicalBonuses;

        [TabGroup("Tab1", "Base Information")]
        [PropertyTooltip("A list of all the effect this ingredient provides to the potions it creates")]
        [SerializeField] List<BaseAlchemicalEffects> negativeAlchemicalBonuses;

        [TabGroup("Tab1", "Base Information")]
        [PropertyTooltip("A list of the effects that can't be applied to a potion using this base unless the effect has a higher tier than the tier shown.")]
        [SerializeField] List<BaseAlchemicalBlockages> alchemicalEffectBlockages;

        #endregion

        #region Serialised Potion Variables

        [TabGroup("Tab1", "Action Information")]
        [PropertyTooltip("A description of the active effect of the potion")]
        [SerializeField] PotionRecipe potionRecipe;

        [TabGroup("Tab1", "Action Information")]
        [PropertyTooltip("A description of the active effect of the potion")]
        [SerializeField] string potionActiveEffectDescription;

        #endregion

        #region Getters for Base Variables

        /// <summary>
        /// Getter for the positive alchemical effect bonsues added to potions crafted with this item.
        /// </summary>
        /// <returns></returns>
        public List<BaseAlchemicalEffects> GetPositiveAlchemicalEffectBonuses()
        {
            return positiveAlchemicalBonuses;
        }

        /// <summary>
        /// Getter for the negative alchemical effect bonuses added to potions crafted with this item.
        /// </summary>
        /// <returns></returns>
        public List<BaseAlchemicalEffects> GetNegativeAlchemicalEffectBonuses()
        {
            return negativeAlchemicalBonuses;
        }

        /// <summary>
        /// Getter for the alchemical blockages of this item.
        /// </summary>
        /// <returns></returns>
        public List<BaseAlchemicalBlockages> GetAlchemicalEffectBlockages()
        {
            return alchemicalEffectBlockages;
        }

        #endregion

        #region Potion Functions

        /// <summary>
        /// Getter for the description of the active effect of the potion.
        /// </summary>
        /// <returns>string of the description</returns>
        public string GetPotionActiveEffect()
        {
            return potionActiveEffectDescription;
        }

        public PotionRecipe GetPotionRecipe()
        {
            return potionRecipe;
        }

        #endregion

        #region Public Functions

        /// <summary>
        /// Function called by the action system.
        /// </summary>
        /// <param name="user">The player/user of the item to be the caster/origin of functionality</param>
        public override void Use(GameObject user)
        {
            // Functionality of the potion

        }

        #endregion

    }
}

