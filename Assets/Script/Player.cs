using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    // Start is called before the first frame update
    public float _speed=8f;
    public float _mouseSpeed=2.0f;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float horizontalInput=Input.GetAxis("Horizontal")*_speed*Time.deltaTime;
        float VirticalInput=Input.GetAxis("Vertical")*_speed*Time.deltaTime;

            transform.Translate(0,0,VirticalInput);
            transform.Translate(horizontalInput,0,0);
            transform.Rotate(0f,0f,0f,Space.World);

        float Mouse_x=_mouseSpeed*Input.GetAxis("Mouse X");
        transform.Rotate(0,Mouse_x,0);
    }
}
