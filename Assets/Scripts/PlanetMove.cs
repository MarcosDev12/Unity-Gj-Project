using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlanetMove : MonoBehaviour
{
    public Transform transform;
    public float spdEarth;

    // Update is called once per frame
    void Update()
    {
        transform.Rotate( 0, spdEarth*Time.deltaTime , 0 );
    }
}
