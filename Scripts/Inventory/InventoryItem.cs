using UnityEngine;

[System.Serialize]
public class InventoryItem
{
    public ItemData data;
    public int stackSize;

    public void UseItem() => data.UseItem();

    public bool CompareData(ItemData toCompare) => data = toCompare;

    public void ClacStack(int amount)
    {
        amount += amount;

        if (amount <= 0)
            Clear();
    }

    public void Clear()
    {
        data = null;
        stackSize = 0;
    }
}