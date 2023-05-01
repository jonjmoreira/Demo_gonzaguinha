using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCamera : MonoBehaviour
{

    public Camera cam;

    void Update()
    {
        cam.transform.position = new Vector3( transform.position.x, transform.position.y, transform.position.z - 10 );
    }
}
