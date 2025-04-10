using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using static UnityEditor.PlayerSettings;

public class player : MonoBehaviour
{
    public GameObject gorgonzola;
    public RectTransform growgrowfruit;
    public UnityEvent yffulDyeknom;
    public GameObject LEMONADESTAND;
    public float ANDHESAIDTOTHEMANRUNNINGTHESTAND;
    public float HEYBOMBOMBOM;
    public float speed = 4;
    Coroutine GOTANYGRAPES;
    public float THEREALtimecount;
    public float THENOTOGtimeyay;
    public GameObject canvasparent;

    // Start is called before the first frame update
    void Start()
    {
    //NOTE: this script is practically identical to the cloud one because I was going to use the same script for both duck and cloud
  // but I needed to tweak a few things on the duck bc cloud is a 2D object and duck is a UI element //

   GOTANYGRAPES = StartCoroutine(THEDUCKWALKEDUPTOTHE()); // starts running the coroutine "THEDUCKWALKEDUPTOTHE"

    }

    // Update is called once per frame
    void Update()
    {
        Vector2 pos = Camera.main.ScreenToWorldPoint(Input.mousePosition); // has the game object gorgonzola follow the mouse position
        gorgonzola.transform.position = pos;
    }

    public void growgrow()
    {
        growgrowfruit.localScale += Vector3.one * 0.5f;
        Debug.Log("omg it grew");
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

        GameObject bob = Instantiate(LEMONADESTAND, new Vector3(Random.Range(-9, 9), -5, 0), Quaternion.identity, canvasparent.transform);
        Debug.Log("grape lemonade");

        Destroy(bob);
        Debug.Log("go away duck or ill duct tape you to a tree duck");
    }
}
