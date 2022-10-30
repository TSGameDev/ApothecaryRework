using System.Collections;
using System.Collections.Generic;
using TSGameDev.Inventories;
using TSGameDev.Inventories.ToolTips;
using Sirenix.OdinInspector;
using TMPro;
using UnityEngine;
using System;

public class BaseItemTooltip : ItemTooltip
{
    #region Serialized Variables

    [SerializeField] TextMeshProUGUI positiveAlchemicalBonusesTxt;
    [SerializeField] TextMeshProUGUI negativeAlchemicalBonusesTxt;
    [SerializeField] TextMeshProUGUI blockagesTxt;

    #endregion

    #region Private variables

    readonly string newline = $"{Environment.NewLine}";

    #endregion

    #region Public functions

    public override void Setup(InventoryItem item)
    {
        base.Setup(item);

        BaseItem baseItem = item as BaseItem;
        BaseSetup(baseItem);
    }

    #endregion

    #region Private Functions

    private void BaseSetup (BaseItem baseItem)
    {
        if (baseItem == null)
            return;

        itemType.text = "Base Ingredient";

        positiveAlchemicalBonusesTxt.text = PositiveBonusesToolTip(baseItem);
        negativeAlchemicalBonusesTxt.text = NegativeBonusesTooltip(baseItem);
        blockagesTxt.text = BloackagesToolTip(baseItem);
    }

    private string PositiveBonusesToolTip(BaseItem baseItem)
    {
        string builderString = $"Positive Bonuses: {newline}";
        List<BaseAlchemicalEffects> positiveBonuses = baseItem.GetPositiveAlchemicalEffectBonuses();

        foreach(BaseAlchemicalEffects bonus in positiveBonuses)
        {
            string effectName = Enum.GetName(typeof(BaseAlchemicalEffects), bonus.effect);
            int effectPercentileBonus = bonus.effectPercentileBonus;

            builderString += $"{effectName} - {effectPercentileBonus}{newline}";
        }

        return builderString;
        
    }

    private string NegativeBonusesTooltip(BaseItem baseItem)
    {
        string builderString = $"Negative Bonuses: {newline}";
        List<BaseAlchemicalEffects> negativeBonuses = baseItem.GetNegativeAlchemicalEffectBonuses();

        foreach(BaseAlchemicalEffects bonus in negativeBonuses)
        {
            string effectName = Enum.GetName (typeof(BaseAlchemicalEffects), bonus.effect);
            int effectPercentileBonus = bonus.effectPercentileBonus;

            builderString += $"{effectName} - {effectPercentileBonus}{newline}";
        }
        return builderString;
    }

    private string BloackagesToolTip(BaseItem baseItem)
    {
        string builderString = $"Blockages: {newline}";
        Dictionary<Effects, int> blockages = baseItem.GetAlchemicalEffectBlockages();

        foreach(KeyValuePair<Effects, int> blockage in blockages)
        {
            Effects effect = blockage.Key;
            int effectTier = blockage.Value;

            builderString += $"{effect} - {effectTier}{newline}";
        }
        return builderString;
    }

    #endregion
}
