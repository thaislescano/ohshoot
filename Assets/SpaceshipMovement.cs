using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceshipMovement : MonoBehaviour {

    float velMax = 5f;

	void Start () {
		
	}
	
	
	void Update () {
        // um/frame :}
        //Input.GetAxis("Vertical"); //float de -1 até 1
        Vector3 pos = transform.position;

        pos.y += Input.GetAxis("Vertical") * velMax * Time.deltaTime;
        transform.position = pos;
		
	}
    //fixedUpdate - quinze/frame - physics
}
