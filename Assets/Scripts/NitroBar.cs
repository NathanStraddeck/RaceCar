using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class NitroBar : MonoBehaviour
{
    public Slider slider;

    public void SetMaxNitro(float Nitro)
    {
        slider.maxValue = Nitro;
        slider.value = Nitro;
    }
    
    public void SetNitro(float nitro)
    {
        slider.value = nitro;
    }
    
}
