using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class EquipmentController : MonoBehaviour
{
    public EquipmentController access;
    public Statusbar SB;
[Serializable]
    public struct Equippable     //Conmumable
    {
        public string name;
        public int wert;
        public GameObject objekt;
        public GameObject slot;
        public int ZWert;
    }
    
    public List<ItemSlot> ItemSlots  = new List<ItemSlot>();

    public List<GameObject> Summs = new List<GameObject>();

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

    public void addItem(GameObject Obj)
    {
        Summs.Add(Obj);
        //hier muss vorher eine funktion rein die denn Wert vom Obj über nimmt undzusammen rechnet
        
        if (Obj.tag == "Orb_H")
        {
            int health;
            // health = Obj.GetComponent<DragDrop>().oneEquip.ZWert + Obj.GetComponent<DragDrop>().oneEquip.wert;
            // SB.access.SetMaxHealth(health);
            // Obj.GetComponent<DragDrop>().oneEquip.ZWert = health + Obj.GetComponent<DragDrop>().oneEquip.wert;
            
            health = Obj.GetComponent<DragDrop>().oneEquip.ZWert + Obj.GetComponent<DragDrop>().oneEquip.wert;
            Obj.GetComponent<DragDrop>().oneEquip.ZWert = health;
            SB.access.SetMaxHealth(health);
            health = 0;
        }
        if (Obj.tag == "Orb_M")
        {
            int maxMana;
            maxMana = Obj.GetComponent<DragDrop>().oneEquip.wert;
            SB.access.SetMaxMana(maxMana);
        }
        if (Obj.tag == "Orb_S")
        {
            int maxStamina;
            maxStamina = Obj.GetComponent<DragDrop>().oneEquip.wert;
            SB.access.SetMaxStamina(maxStamina);
        }
    }

    public void removeItem(GameObject Obj)
    {
        Summs.Remove(Obj);
    }


}
