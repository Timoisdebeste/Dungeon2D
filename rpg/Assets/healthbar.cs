using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class healthbar : MonoBehaviour
{

public Slider Slider;

public void Sethealth (int health)
{
    Slider.value = health
}
}