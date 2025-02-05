using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeepStillObject : MonoBehaviour

{

    // The fixed position where you want the object to stay

    public Vector3 fixedPosition = new Vector3(0, 0, 0);

    void Start()

    {

        // Set the object's position to the fixed position at the start

        transform.position = fixedPosition;

    }

}
