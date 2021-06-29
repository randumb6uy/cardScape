using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class HUD : MonoBehaviour
{
   public Text nameText;
   
   public Slider hpSlider;
   public void SetHud(unit unit)
   {
       nameText.text = unit.unitName;
       hpSlider.maxValue = unit.maxHealth;
       hpSlider.value  = unit.health;
       
   }
}
