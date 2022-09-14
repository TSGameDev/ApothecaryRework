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

        private void Awake()
        {
            playerConnector.GetInventoryUITween = () =>
            {
                if (inventoryTweenProfile == null)
                    return null;

                return inventoryTweenProfile;
            };
        }
    }
}
