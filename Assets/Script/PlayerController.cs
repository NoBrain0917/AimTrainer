using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    [SerializeField] Transform holder;
    public static float mouseSenstivity = 1;
    float lookRotation;
    public static bool isMove = true;

    // Start is called before the first frame update
    void Start()
    {
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        if(isMove) {
            transform.Rotate(Vector3.up * Input.GetAxisRaw("Mouse X")*mouseSenstivity);
            lookRotation -= Input.GetAxisRaw("Mouse Y")*mouseSenstivity;
            lookRotation = Mathf.Clamp(lookRotation,-90f,90f);
            holder.localEulerAngles = new Vector3(lookRotation,0,0);
        }
    }
}
