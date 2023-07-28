using UnityEngine;

[CreateAssetMenu(menuName = "ScriptableObjects/ItemData/Equipment/Normal", fileName = "new Equipment")]
public class EquipmentItemData : ItemData
{
    [Header("Equipment")]
    public float defense;
}