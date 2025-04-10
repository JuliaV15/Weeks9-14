using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class THEDUCKFLIES : MonoBehaviour
{
    public GameObject LEMONADESTAND;
    public float ANDHESAIDTOTHEMANRUNNINGTHESTAND;
    public float HEYBOMBOMBOM;
    public float speed = 4;
    Coroutine GOTANYGRAPES;
    public float THEREALtimecount;
    public float THENOTOGtimeyay;
    public GameObject canvasparent;

  // NOTE: this script is practically identical to the cloud one because I was going to use the same script for both duck and cloud
  // but I needed to tweak a few things on the duck bc cloud is a 2D object and duck is a UI element //

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 pos = transform.position; // makes duck move upwards forever
        pos.y += speed * Time.deltaTime;

        transform.position = pos;
    }

    
}
