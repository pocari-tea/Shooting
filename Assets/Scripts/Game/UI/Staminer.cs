using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Staminer : MonoBehaviour
{
    [SerializeField] private Image Staminer_bar;

    private void Start()
    {
        Staminer_bar = GameObject.Find("Staminer_bar").GetComponent<Image>();
    }

    private void Update()
    {
        Staminer_bar.fillAmount = Player.instance.staminer / 100f;
    }
}
