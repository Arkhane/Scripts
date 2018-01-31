using UnityEngine;

public enum EquipmentType
{
    Tool,
    BackpackItem,
}

[CreateAssetMenu]
public class EquippableItem : Item {

    public int StrengthBonus;
    public int AgilityBonus;
    public int IntelligenceBonus;
    public int VitalityBonus;
    [Space]
    public float StrengthPercentBonus;
    public float AgilityPercentBonus;
    public float IntelligencePercentBonus;
    public float VitalityPercentBonus;
    [Space]
    public EquipmentType EquipmentType;
}
