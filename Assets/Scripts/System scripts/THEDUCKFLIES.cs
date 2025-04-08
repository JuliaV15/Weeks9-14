using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class THEDUCKFLIES : MonoBehaviour
{
    public GameObject LEMONADESTAND;
    public float ANDHESAIDTOTHEMANRUNNINGTHESTAND;
    public float HEYBOMBOMBOM;
    public float speed = 500;
    Coroutine GOTANYGRAPES;
    public float THEREALtimecount;
    public float THENOTOGtimeyay;
    public GameObject canvasparent;

  // NOTE: this script is practically identical to the cloud one because I was going to use the same script for both duck and cloud
  // but I needed to tweak a few things on the duck bc cloud is a 2D object and duck is a UI element //

    // Start is called before the first frame update
    void Start()
    {
        GOTANYGRAPES = StartCoroutine(THEDUCKWALKEDUPTOTHE());
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 pos = transform.position; // makes duck move upwards forever
        pos.y += speed * Time.deltaTime;

        transform.position = pos;
    }

    IEnumerator THEDUCKWALKEDUPTOTHE()
    {
        THENOTOGtimeyay = Random.Range(2, 3); // gives a random time value from the range 2 - 3
        THEREALtimecount = 0; // resets the timer

        while (THEREALtimecount < THENOTOGtimeyay)
        {
            THEREALtimecount += Time.deltaTime;
            yield return null; // loops this till timecount > timeyay and then moves on to the lower lines (instantiate)
        }

        Instantiate(LEMONADESTAND, new Vector3(Random.Range(500, 1200), -352, 0), Quaternion.identity, canvasparent.transform);
        Debug.Log("grape lemonade");

        Destroy(LEMONADESTAND);
        Debug.Log("go away duck or ill duct tape you to a tree duck");
    }
}
