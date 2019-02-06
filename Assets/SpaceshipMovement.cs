using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceshipMovement : MonoBehaviour {

    float velMax = 5f;
    float rotSpeed = 180f;

	void Start () {
		
	}
	
	
	void Update () {

        //rotation quaternion
        Quaternion rot = transform.rotation;

        //z euler angle
        float z = rot.eulerAngles.z;

        //chage z angle based on input
        z -= Input.GetAxis("Horizontal") * rotSpeed * Time.deltaTime;

        //recreate quaternion
        rot = Quaternion.Euler(0, 0, z);
        
        //feed quaternion into rotation
        transform.rotation = rot;

        // um/frame :}
        //Input.GetAxis("Vertical"); //float de -1 até 1
        Vector3 pos = transform.position;

        pos.y += Input.GetAxis("Vertical") * velMax * Time.deltaTime;
        transform.position = pos;
		
	}
    //fixedUpdate - quinze/frame - physics
}
