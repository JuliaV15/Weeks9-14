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
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 pos = transform.position; // makes cloud move upwards forever
        pos.y += speed * Time.deltaTime;

        Vector3 direction = (Vector3)transform.position;
        transform.up = direction;

        transform.position = pos;

    }

    private IEnumerator backgroundwoosh ()
    {
        timeyay = Random.Range(2, 5); // gives a random time value from the range 2 - 5
        Destroy(cloud, 3); // destroy the c louds after 3 sec


        while (timecount < timeyay)
        {
           timecount += Time.deltaTime;
            yield return null;
        }

        Instantiate(cloud, new Vector3 (-8, -5, 0), Quaternion.identity); // instantite clouds at (-8, -5)
       
    }
}
