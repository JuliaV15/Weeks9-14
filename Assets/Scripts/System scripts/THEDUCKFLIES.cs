using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class THEDUCKFLIES : MonoBehaviour
{
    public GameObject LEMONADESTAND;
    public float ANDHESAIDTOTHEMANRUNNINGTHESTAND;
    public float HEYBOMBOMBOM;
    public float speed = 8;
    Coroutine GOTANYGRAPES;

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
        Vector3 pos = transform.position; // makes cloud move upwards forever
        pos.y += speed * Time.deltaTime;

        transform.position = pos;
    }

    IEnumerator THEDUCKWALKEDUPTOTHE()
    {
        Instantiate(LEMONADESTAND, new Vector3(Random.Range(9, -9), -5, 0), Quaternion.identity);
        Debug.Log("grape lemonade");

        Destroy(LEMONADESTAND, 5);
        Debug.Log("go away duck or ill duct tape you to a tree duck");

        yield return null;
    }
}
