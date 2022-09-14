using UnityEngine;
using TSGameDev.Inventories;
using TSGameDev.Inventories.Equipment;
using TSGameDev.Inventories.Actions;
using TSGameDev.UI.Tween;

public class Test : MonoBehaviour
{
    public MultiElementTweenProfile tweenProfile;

    [SerializeField] EquipableItem helm;
    [SerializeField] ActionItem testActionItem1;
    [SerializeField] ActionItem testActionItem2;
    [SerializeField] ActionItem testActionItem3;
    [SerializeField] Inventory playerInventory;
    [SerializeField] ActionStore actionStore;

    // Start is called before the first frame update
    void Start()
    {
        playerInventory.AddToFirstEmptySlot(helm, 1);
        playerInventory.AddToFirstEmptySlot(testActionItem1, 1);
        playerInventory.AddToFirstEmptySlot(testActionItem2, 1);
        playerInventory.AddToFirstEmptySlot(testActionItem3, 1);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            tweenProfile.ActiveTweenLoop();
        }

        if(Input.GetKeyDown(KeyCode.Alpha1))
        {
            actionStore.Use(0, gameObject);
        }

        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            actionStore.Use(1, gameObject);
        }

        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            actionStore.Use(2, gameObject);
        }
    }
}
