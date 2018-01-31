using System.Collections;
using UnityEngine;

public class BaseWeapon : MonoBehaviour { //BaseWeapon <- BaseStatItem <- BaseItem

	public enum WeaponTypes
    {
        HOE,
        AXE,
        HAMMER,
    }

    private WeaponTypes weaponType;
    private int spellEffect;

    public WeaponTypes WeaponType
    {
        get { return weaponType; }
        set { weaponType = value; }
    }

    public int SpellEffectID
    {
        get { return spellEffect; }
        set { spellEffect = value; }
    }
}
