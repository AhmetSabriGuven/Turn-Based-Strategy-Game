using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public enum UnitType
{
    Warrior,
    Archer,
    Cleric
}

[System.Serializable]
public class UnitData
{
    public string id;

    public UnitType unitType;

    public Vector3 position;

    public Quaternion rotation;
}