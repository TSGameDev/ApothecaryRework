using System.Collections;
using System.Collections.Generic;
using TSGameDev.Controls;
using UnityEngine;

namespace TSGameDev.UI.Tween
{
    public class TweenManager : MonoBehaviour
    {
        [SerializeField] PlayerConnector playerConnector;

        [SerializeField] TweenProfile inventoryTweenProfile;
        [SerializeField] TweenProfile equipmentTweenProfile;
        [SerializeField] TweenProfile statsTweenProfile;
        [SerializeField] TweenProfile hudIconTweenProfile;

        private void Awake()
        {
            playerConnector.GetInventoryUITween = () =>
            {
                if (inventoryTweenProfile == null)
                    return null;

                return inventoryTweenProfile;
            };

            playerConnector.GetEquipmentUITween = () =>
            {
                if (equipmentTweenProfile == null)
                    return null;

                return equipmentTweenProfile;
            };

            playerConnector.GetStatsUITween = () =>
            {
                if (statsTweenProfile == null)
                    return null;

                return statsTweenProfile;
            };

            playerConnector.GetHUDIconUITween = () =>
            {
                if (hudIconTweenProfile == null)
                    return null;

                return hudIconTweenProfile;
            };

        }
    }
}
