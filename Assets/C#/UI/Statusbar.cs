using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class Statusbar : MonoBehaviour
{

    public Slider H_slider;
    public Slider M_slider;
    public Slider S_slider;

    public Text H_text;
    public Text M_text;
    public Text S_text;

    public Statusbar access;

    // text setzt sich zusammen aus health + / + maxHealth

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

    public void SetMaxHealth(int health)
    {
        H_slider.maxValue = health;
        H_slider.value = health;
        H_text.text = health.ToString(); 
    }
    public void SetHealth(int health)
    {
        H_slider.value = health;
    }

    public void SetMaxMana(int mana)
    {
        M_slider.maxValue = mana;
        M_slider.value = mana;
        M_text.text = mana.ToString();
    }
    public void SetMana(int mana)
    {
        M_slider.value = mana;
    }

    public void SetMaxStamina(int stamina)
    {
        S_slider.maxValue = stamina;
        S_slider.value = stamina;
        S_text.text = stamina.ToString();
    }
    public void SetStamina(int stamina)
    {
        S_slider.value = stamina;
    }
}
