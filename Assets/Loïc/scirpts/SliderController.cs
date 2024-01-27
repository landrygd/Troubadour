using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SliderControl : MonoBehaviour
{
    public Text valueText;
    float progress = 0;
    public Slider slider;
    public void OnSliderChanged(float value)
    {
        valueText.text = value.ToString();
    }
    public void UpdateProgress()
    {
        progress++;
        slider.value = progress;
    }
    void Update()
    {
        if (slider.value>0)
        {
            progress = progress - (1f * Time.deltaTime * 5);
            slider.value = progress;
        }
    }
}
