using System.Collections.Generic;
using UnityEngine;
using Sirenix.OdinInspector;

namespace TSGameDev.Inventories
{
    public struct BaseAlchemicalEffects
    {
        public Effects effect;

        [MinValue(1)]
        [MaxValue(100)]
        public int effectPercentileBonus;

        public BaseAlchemicalEffects(Effects effect, int effectPercentileBonus = 1)
        {
            this.effect = effect;
            this.effectPercentileBonus = effectPercentileBonus;
        }
    }

    [CreateAssetMenu(menuName = ("TSGameDev/Inventory/New Base Item"))]
    public class BaseItem : InventoryItem
    {
        #region Serialsied Variables

        [TabGroup("Tab1", "Base Information")]
        [PropertyTooltip("A list of all the effect this ingredient provides to the potions it creates")]
        [SerializeField] List<BaseAlchemicalEffects> positiveAlchemicalEffectBonuses;

        [TabGroup("Tab1", "Base Information")]
        [PropertyTooltip("A list of all the effect this ingredient provides to the potions it creates")]
        [SerializeField] List<BaseAlchemicalEffects> negativeAlchemicalEffectBonuses;

        [PropertyTooltip("A Dictionary of Effects and tiers. The effects of stated tier or lower can't be put on this item, higher tiers of this effect are potent enough to be able to be applied to this item.")]
        [SerializeField] Dictionary<Effects, int> alchemicalEffectBlockages = new();

        #endregion

        #region Public functions

        public List<BaseAlchemicalEffects> GetPositiveAlchemicalEffectBonuses()
        {
            return positiveAlchemicalEffectBonuses;
        }

        public List<BaseAlchemicalEffects> GetNegativeAlchemicalEffectBonuses()
        {
            return negativeAlchemicalEffectBonuses;
        }

        public Dictionary<Effects, int> GetAlchemicalEffectBlockages()
        {
            return alchemicalEffectBlockages;
        }

        #endregion

    }
}
