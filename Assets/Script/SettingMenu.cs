using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SettingMenu : MonoBehaviour
{

    [SerializeField] Canvas menu;
    public static bool isShowing = false;

    // Start is called before the first frame update
    void Start()
    {
        menu.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(TimeManager.isStop) return;
        if(Input.GetKeyDown(KeyCode.Escape)) {
            isShowing = !isShowing;
            PlayerController.isMove = !isShowing;
            if(!isShowing) {
                Cursor.visible = false;
                Cursor.lockState = CursorLockMode.Locked;
            } else {
                Cursor.visible = true;
                Cursor.lockState = CursorLockMode.None;
            }
            menu.enabled = isShowing;

        }
    }
}
