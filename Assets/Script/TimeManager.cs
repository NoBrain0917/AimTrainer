using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeManager : MonoBehaviour
{

    [SerializeField] Text timeText;
    [SerializeField] Text point;
    [SerializeField] Canvas end;
    [SerializeField] Text showPoint;
    [SerializeField] Text pointText;
    private static float time = 60;
    public static bool isStop = false;
    public static int bestpoint = 0;
    // Start is called before the first frame update


    public static void retry(){
        time = 60;
        isStop = false;
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {   
        if(!isStop) { 
            if(SettingMenu.isShowing) return;
            time -= Time.deltaTime;
            timeText.text = "0:"+string.Format("{0:N0}",time);
        }
        if(time<=0) {
            isStop = true;
            PlayerController.isMove = false;
            end.enabled = true;
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;
            SettingMenu.isShowing = true;
            showPoint.text = point.text;
            if(bestpoint<int.Parse(point.text)) {
                pointText.text = "Best Point";
                bestpoint = int.Parse(point.text);
            } else {
                pointText.text = "Point";
            }
        }
    }

}
