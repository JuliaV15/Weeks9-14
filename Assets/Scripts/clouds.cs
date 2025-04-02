using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;
using static UnityEditor.PlayerSettings;

public class clouds : MonoBehaviour
{
    public GameObject cloud;
    public float speed = 5;

    // Start is called before the first frame update
    void Start()
    {
        Instantiate(cloud); // instantite clouds
        Destroy(cloud, 2); // destroy the c louds after 2 sec
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
}
