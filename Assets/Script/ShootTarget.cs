using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShootTarget : MonoBehaviour
{

    [SerializeField] Camera camera;
    [SerializeField] Text point;


    // Start is called before the first frame update
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
        if(SettingMenu.isShowing) return;
        if(Input.GetMouseButtonDown(0)) {
            Ray ray = camera.ViewportPointToRay(new Vector3(0.5f,0.5f));
            if(Physics.Raycast(ray,out RaycastHit hit)) {
                Target target = hit.collider.gameObject.GetComponent<Target>();
                AudioSource audio = GameObject.Find("Player").GetComponent<AudioSource>();
                audio.Play();

                if(target!=null) {
                    target.Hit();
                    AudioSource audio2 = target.GetComponent<AudioSource>();
                    audio2.Play();
                    point.text = (int.Parse(point.text)+10).ToString();
                } else {
                    point.text = (int.Parse(point.text)-5).ToString();
                }
                
            }
        }
    }
}
