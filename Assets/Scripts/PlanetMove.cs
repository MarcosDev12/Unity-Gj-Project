using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlanetMove : MonoBehaviour
{
    public static PlanetMove instance;
    public bool Rotation = true;
    public Transform transform;
    public float spdEarth;

    // Update is called once per frame
    void Update()
    {
        if(Rotation == false)
        {
            spdEarth = 0;
        }
        
        if(Rotation == true)
        {
            spdEarth = -10f;
            transform.Rotate(0, spdEarth * Time.deltaTime, 0);
        }
        
    }

    private void Awake()
    {
        instance = this;
    }
}
