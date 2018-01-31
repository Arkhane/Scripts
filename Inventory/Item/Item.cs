using UnityEngine;

public enum ItemType
{
    Tool,
    BackpackItem,
}

[CreateAssetMenu]
public class Item : ScriptableObject
{
    public string ItemName;
    public Sprite Icon;

    [Space]
    public ItemType ItemType;

}
