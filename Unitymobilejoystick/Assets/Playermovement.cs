using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playermovement : MonoBehaviour
{
    public Joystick Joystick1;
    public Transform Maincamera;
    public CharacterController Bodymovement;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Assign the joystick to a variable
        float Horizontalstick = Joystick1.Horizontal;
        float Verticalstick = Joystick1.Vertical;
        Vector3 camF = Maincamera.forward;
        Vector3 Camy = Maincamera.right;
        camF.y = 0;
        Camy.y = 0;
        //Make sure that the character move forward at the direction of where the camera is facing
        var Movingdirection = camF * Verticalstick + Camy * Horizontalstick;
        Bodymovement.Move(Movingdirection * 15f * Time.deltaTime);

    }
}
