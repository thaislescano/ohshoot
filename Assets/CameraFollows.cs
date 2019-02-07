using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollows : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform myTarget;

    // Update is called once per frame
    void Update()
    {
       if (myTarget != null)
        {
            Vector3 targPos = myTarget.position;
            targPos.z = transform.position.z;
            transform.position = targPos;
        }
    }
}
