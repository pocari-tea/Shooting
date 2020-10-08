using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HP : MonoBehaviour
{
    [SerializeField] private Text HP_Text;
    [SerializeField] private Image HP_bar;
    
    private void Start()
    {
        HP_bar = GameObject.Find("HP_bar").GetComponent<Image>();
        HP_Text = GameObject.Find("HP_Text").GetComponent<Text>();
    }

    private void Update()
    {
        HP_Text.text = "HP : " + Player.instance.hp;
        HP_bar.fillAmount = Player.instance.hp / 100f;
    }
}
