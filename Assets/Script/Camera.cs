using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    // Start is called before the first frame update
    private float mouseSpeedy=2.0f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float Mouse_y=mouseSpeedy*Input.GetAxis("Mouse Y");
        if(Mouse_y<=90f){
            transform.Rotate(-Mouse_y,0,0);
        }
    }
}
