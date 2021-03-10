using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonEvent : MonoBehaviour
{
    [SerializeField] GameObject button;
    [SerializeField] Canvas menu;
    [SerializeField] Canvas end;
    [SerializeField] Text point;
    [SerializeField] Text time;

    public void applySenstivity()
    {
        float volume = GameObject.Find("Slider").GetComponent<Slider>().value;
        PlayerController.mouseSenstivity = volume;
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
        menu.enabled = false;
        SettingMenu.isShowing = false;
        PlayerController.isMove = true;
    }

    public void exit(){
        #if UNITY_EDITOR
            UnityEditor.EditorApplication.isPlaying = false;
        #else 
            Application.Quit();
        #endif
    }

    public void retry(){
        TimeManager.retry();
        end.enabled = false;
        point.text = "0";
        time.text = "0:60";
        menu.enabled = false;
        PlayerController.isMove = true;
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
        SettingMenu.isShowing=false;
    }
}
