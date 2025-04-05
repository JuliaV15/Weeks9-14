using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor.Experimental.GraphView;
using UnityEngine;
using static UnityEditor.PlayerSettings;

public class clouds : MonoBehaviour
{
    public GameObject cloud;
    public float speed = 5;
    public float timecount;
    Coroutine timerthing;
    public float timeyay;

    // Start is called before the first frame update
    void Start()
    {
        timerthing = StartCoroutine(backgroundwoosh());
        Debug.Log("bazinga");
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 pos = transform.position; // makes cloud move upwards forever
        pos.y += speed * Time.deltaTime;

        transform.position = pos;
    }

    private IEnumerator backgroundwoosh ()
    {
        timeyay = Random.Range(2, 5); // gives a random time value from the range 2 - 5
        timecount = 0; // resets the timer

        while (timecount < timeyay)
        {
           timecount += Time.deltaTime;
            yield return null; // loops this till timecount > timeyay and then moves on to the lower lines (instantiate)
        }

        Instantiate(cloud, new Vector3 (-8, -5, 0), Quaternion.identity); // instantite clouds at (-8, -5)
        Destroy(cloud); // destroy the c louds
        Debug.Log("oh look a cloud");
    }
}
