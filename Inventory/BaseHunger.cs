[System.Serializable]

public class BaseHunger : BaseStat
{

    public BaseHunger()
    {
        StatName = "Hunger";
        StatDescription = "Directly modifies player's hunger.";
        StatType = StatTypes.HUNGER;
        StatBaseValue = 0;
        StatModifiedValue = 0;

    }
}
