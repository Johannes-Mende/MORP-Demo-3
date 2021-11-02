using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class EquipmentController : MonoBehaviour
{
    public EquipmentController access;
[Serializable]
    public struct Equippable     //Conmumable
    {
        public string name;
        public int wert;
        public GameObject objekt;
        public GameObject slot;
    }
    
    public List<ItemSlot> ItemSlots  = new List<ItemSlot>();

    public List<GameObject> HealthSumm = new List<GameObject>();
    public List<GameObject> ManaSumm = new List<GameObject>();
    public List<GameObject> StaminaSumm = new List<GameObject>();

    void Awake()
    {
        access = this;
    }

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    public void onEquipped(GameObject Obj)
    {
        print("bums"+ Obj.name);
        
        for (int i = 0; i < ItemSlots.Count; i++)
        {
            //ItemSlots[i] = default;
            
            if (true)
            {
                
            }
            if (true)
            {
                
            }
            if (true)
            {
                
            }
        }
    }


}
