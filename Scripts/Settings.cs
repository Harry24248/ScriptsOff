using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Settings : MonoBehaviour
{
    public Toggle toggleFull;

    public void OnEnable()
    {
        toggleFull.onValueChanged.AddListener(delegate { FullScreen();});
    }


    public void FullScreen()
    {
        if (toggleFull.isOn) {Screen.fullScreen = true;}
        else {Screen.fullScreen = false;}
    }
    public void OnDisable()
    {
        toggleFull.onValueChanged.RemoveAllListeners();
    }
}
