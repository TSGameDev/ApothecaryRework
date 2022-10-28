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

        itemType.text = "Reagent Ingredient";

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

        }

        
    }

    private string NegativeBonusesTooltip(BaseItem baseItem)
    {

    }

    private string BloackagesToolTip(BaseItem baseItem)
    {

    }

    #endregion
}
