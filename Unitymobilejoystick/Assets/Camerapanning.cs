using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camerapanning : MonoBehaviour
{
    public float SpeedH = 2f;
    public float SpeedV = 2f;
    public float yaw;
    public float pitch;
    public Joystick Lookaroundjoystick;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Assign the panning and looking function to a joystick
        yaw -= SpeedH * Lookaroundjoystick.Vertical;
        pitch += SpeedV * Lookaroundjoystick.Horizontal;
        transform.eulerAngles = new Vector3(yaw, pitch, 0f);

        
    }
}
