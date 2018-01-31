using System.Collections;
using UnityEngine;

public class BaseStatItem : MonoBehaviour {

    private int hunger;
    private int stamina;
    


    public int Hunger
    {
        get { return hunger; }
        set { hunger = value; }
    }

    public int Stamina
    {
        get { return stamina; }
        set { stamina = value; }
    }


}
