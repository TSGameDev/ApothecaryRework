using UnityEngine;
using TSGameDev.UI.Tween;

namespace TSGameDev.Controls
{
    public enum TweenState
    { 
        Open,
        Close
    }

    [CreateAssetMenu(fileName = "New Player Connector", menuName = "TSGameDev/Controls/New Player Connector")]
    public class PlayerConnector : ScriptableObject
    {
        public delegate TweenProfile GetTweenProfile();
        public GetTweenProfile GetInventoryUITween;
        public TweenState InventoryTweenState = TweenState.Close;

        public GetTweenProfile GetEquipmentUITween;
        public TweenState EquipmentTweenState = TweenState.Close;

        public GetTweenProfile GetStatsUITween;
        public TweenState StatsTweenState = TweenState.Close;

        public GetTweenProfile GetHUDIconUITween;
        public TweenState HUDIconTweenState = TweenState.Close;

        public void InventoryTween()
        {
            if (GetInventoryUITween == null)
                return;

            TweenProfile profile = GetInventoryUITween();

            if (profile == null)
                return;

            if (InventoryTweenState == TweenState.Close)
            {
                profile.ActivateTween();
                InventoryTweenState = TweenState.Open;
            }
            else
            { 
                profile.DeactivateTween();
                InventoryTweenState = TweenState.Close;
            }
        }

        public void EquipmentTween()
        {
            if (GetEquipmentUITween == null)
                return;

            TweenProfile profile = GetEquipmentUITween();

            if (profile == null)
                return;

            if(EquipmentTweenState == TweenState.Close)
            {
                profile.ActivateTween();
                EquipmentTweenState = TweenState.Open;
            }
            else
            {
                profile.DeactivateTween();
                EquipmentTweenState = TweenState.Close;
            }
        }

        public void StatsTween()
        {
            if (GetStatsUITween == null)
                return;

            TweenProfile profile = GetStatsUITween();

            if (profile == null)
                return;

            if(StatsTweenState == TweenState.Close)
            {
                profile.ActivateTween();
                StatsTweenState = TweenState.Open;
            }
            else
            {
                profile.DeactivateTween();
                StatsTweenState = TweenState.Close;
            }
        }

        public void HUDIconTween()
        {
            if (GetHUDIconUITween == null)
                return;

            TweenProfile profile = GetHUDIconUITween();

            if (profile == null)
                return;

            if (HUDIconTweenState == TweenState.Close)
            {
                profile.ActivateTween();
                HUDIconTweenState = TweenState.Open;
            }
            else
            {
                profile.DeactivateTween();
                HUDIconTweenState = TweenState.Close;
            }
        }
    }
}
