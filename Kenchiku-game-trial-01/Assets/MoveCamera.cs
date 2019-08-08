using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCamera: MonoBehaviour
{
    public float y_sensitivity;
    public float x_sensitivity;
    public float key_sensitivity;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float y_mouse = Input.GetAxis("Mouse Y");

        Vector3 newRotation = transform.localEulerAngles;
        newRotation.x -= y_mouse * y_sensitivity;
        transform.localEulerAngles = newRotation;

        float x_mouse = Input.GetAxis("Mouse X");

        Vector3 newRotation2 = transform.localEulerAngles;
        newRotation2.y -= x_mouse * -x_sensitivity;
        transform.localEulerAngles = newRotation2;


        // 左に移動
        if (Input.GetKey (KeyCode.LeftArrow)) {
            this.transform.Translate (-key_sensitivity, 0.0f,0.0f);
        }
        // 右に移動
        if (Input.GetKey (KeyCode.RightArrow)) {
            this.transform.Translate (key_sensitivity, 0.0f,0.0f);
        }
        // 前に移動
        if (Input.GetKey (KeyCode.UpArrow)) {
            this.transform.Translate (0.0f,0.0f, key_sensitivity);
        }
        // 後ろに移動
        if (Input.GetKey (KeyCode.DownArrow)) {
            this.transform.Translate (0.0f,0.0f,-key_sensitivity);
        }
    }
}
