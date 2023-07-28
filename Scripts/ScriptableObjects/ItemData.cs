using UnityEngine;

[CreateAssetMenu(menuName = "ScriptableObjects/ItemData/Normal", fileName = "new ItemData")]
public class ItemData : ScriptableObject
{
    [Header("Item")]
    public string itemDescription;
    public float weight;
    public int maxStack;
    public Vector2 itemSize;

    public virtual void PickUpItem()
    {
        Debug.Log("Picking up item " + this.name);
    }

    public virtual void UseItem()
    {
        Debug.Log("Using item " + this.name);
    }
}