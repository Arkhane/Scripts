[System.Serializable]


public class BaseEndurance : BaseStat
{

    public BaseEndurance()
    {
        StatName = "Endurance";
        StatDescription = "Directly modifies player's energy.";
        StatType = StatTypes.EDURANCE;
        StatBaseValue = 0;
        StatModifiedValue = 0;

    }
}
