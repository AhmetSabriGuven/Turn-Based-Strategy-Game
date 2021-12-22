using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnitHandler : MonoBehaviour
{
    public UnitType unitType;

    public UnitData unitData;

    void Start()
    {
        if (string.IsNullOrEmpty(unitData.id))
        {
            unitData.id = System.DateTime.Now.ToLongDateString() + System.DateTime.Now.ToLongTimeString() + Random.Range(0, int.MaxValue).ToString();
            unitData.unitType = unitType;
            SaveData.currrent.units.Add(unitData);
        }

        GameEvents.current.onLoadEvent += DestroyMe;
        
    }


    void Update()
    {
        
    }

    void DestroyMe()
    {
        GameEvents.current.onLoadEvent -= DestroyMe;
        Destroy(gameObject);
    }
}
