using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SliderManager : MonoBehaviour
{

    [SerializeField] GameObject slider;
    [SerializeField] Text sens;

    public void editSenstivity(float newValue){
        sens.text = (newValue).ToString();
    }

}
