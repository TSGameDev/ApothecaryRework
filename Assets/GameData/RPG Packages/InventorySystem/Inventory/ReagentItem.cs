using System.Collections.Generic;
using UnityEngine;
using Sirenix.OdinInspector;

namespace TSGameDev.Inventories
{
    public struct BunsenBurnerProcess
    {
        [MinValue(1)]
        [MaxValue(299)]
        public int minTemp;
        [MinValue(2)]
        [MaxValue(300)]
        public int maxTemp;
        public InventoryItem result;

        public BunsenBurnerProcess(InventoryItem result, int minTemp = 1, int maxTemp = 300)
        {
            this.minTemp = minTemp;
            this.maxTemp = maxTemp;
            this.result = result;
        }
    }

    [CreateAssetMenu(menuName = ("TSGameDev/Inventory/New Reagent Item"))]
    public class ReagentItem : InventoryItem
    {
        #region Serialised Variables

        [TabGroup("Tab1", "Reagent Information")]
        [PropertyTooltip("A list of all the effect this ingredient provides to the potions it creates")]
        [SerializeField] Dictionary<Effects, int> alchemicalEffects = new();

        [TitleGroup("Tab1/Reagent Information/Mortar and Pestle Results")]
        [HorizontalGroup("Tab1/Reagent Information/Mortar and Pestle Results/Mortar")]
        [LabelText("Primary Result")]
        [PreviewField(50, ObjectFieldAlignment.Left)]
        [PropertyTooltip("The primary result of this ingredient when processed under mortar and pestle.")]
        [SerializeField] InventoryItem mortarAndPestleResult;

        [HorizontalGroup("Tab1/Reagent Information/Mortar and Pestle Results/Mortar")]
        [LabelText("Secondry Result")]
        [PreviewField(50, ObjectFieldAlignment.Center)]
        [PropertyTooltip("The secondary result of this ingredient when processed under mortar and pestle.")]
        [SerializeField] InventoryItem mortarAndPestleResult2;

        [TitleGroup("Tab1/Reagent Information/Blender Results")]
        [HorizontalGroup("Tab1/Reagent Information/Blender Results/Blender")]
        [LabelText("Primary Result")]
        [PreviewField(50, ObjectFieldAlignment.Left)]
        [PropertyTooltip("the result of this ingredient when process under blender.")]
        [SerializeField] InventoryItem blenderResult;

        [TitleGroup("Tab1/Reagent Information/Juicer Results")]
        [HorizontalGroup("Tab1/Reagent Information/Juicer Results/Juicer")]
        [LabelText("Primary Result")]
        [PreviewField(50, ObjectFieldAlignment.Left)]
        [PropertyTooltip("The primary result of this ingredient when processed under juicer.")]
        [SerializeField] InventoryItem juicerResult;

        [HorizontalGroup("Tab1/Reagent Information/Juicer Results/Juicer")]
        [LabelText("Secondry Result")]
        [PreviewField(50, ObjectFieldAlignment.Center)]
        [PropertyTooltip("The secondary result of this ingredient when processed under juicer.")]
        [SerializeField] InventoryItem juicerResult2;

        [TitleGroup("Tab1/Reagent Information/Chopping Results")]
        [HorizontalGroup("Tab1/Reagent Information/Chopping Results/Chopping")]
        [LabelText("Primary Result")]
        [PreviewField(50, ObjectFieldAlignment.Left)]
        [PropertyTooltip("The primary result of this ingredient when processed under chopping.")]
        [SerializeField] InventoryItem choppingResult;

        [HorizontalGroup("Tab1/Reagent Information/Chopping Results/Chopping")]
        [LabelText("Secondry Result")]
        [PreviewField(50, ObjectFieldAlignment.Center)]
        [PropertyTooltip("The secondary result of this ingredient when processed under chopping.")]
        [SerializeField] InventoryItem choppingResult2;

        [Title("Bunson Burner Results")]
        [TabGroup("Tab1", "Reagent Information")]
        [PropertyTooltip("A list of all the results of this ingredient when processed under bunsen burner.")]
        [SerializeField] List<BunsenBurnerProcess> bunsenburnerResults = new();

        #endregion

        #region Public Functions

        public Dictionary<Effects, int> GetReagentEffects()
        {
            return alchemicalEffects;
        }

        public int SearchReagentEffect(Effects effect)
        {
            if (!alchemicalEffects.ContainsKey(effect))
                return 0;

            return alchemicalEffects[effect];
        }

        public InventoryItem GetMortarPrimaryResult()
        {
            return mortarAndPestleResult;
        }

        public InventoryItem GetMortarSecondaryResult()
        {
            return mortarAndPestleResult2;
        }

        public InventoryItem GetBlendingResult()
        {
            return blenderResult;
        }

        public InventoryItem GetJuicerPrimaryResult()
        {
            return juicerResult;
        }

        public InventoryItem GetJuicerSecondaryResult()
        {
            return juicerResult2;
        }

        public InventoryItem GetChoppingPrimaryResult()
        {
            return choppingResult;
        }

        public InventoryItem GetChoppingSecondaryResult()
        {
            return choppingResult2;
        }

        public List<BunsenBurnerProcess> GetBunsenBurnerProcesses()
        {
            return bunsenburnerResults;
        }

        #endregion

    }
}
