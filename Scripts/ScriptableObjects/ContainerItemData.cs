using UnityEngine; 

[CreateAssetMenu(menuName = "ScriptableObjects/ItemData/Equipment/Container", fileName = "new Container")]
public class ContainerItemData : EquipmentItemData
{
    [Header("Container")]
    public Vector2 containerSize;
    public float maxWeight;

    public override void UseItem()
    {
        Debug.Log("Equip Contianer " + this.name);
    }
}