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
    }
}
