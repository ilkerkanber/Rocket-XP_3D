using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace SampleProject3D.UI {
    public class FuelSlider : MonoBehaviour
    {
        Fuel fuel;
        Slider slider;
        private void Awake()
        {
            fuel = FindObjectOfType<Fuel>();
            slider = GetComponent<Slider>();
        }
        void Update()
        {
            slider.value = fuel.CurrentFuel;   
        }
    }

}
