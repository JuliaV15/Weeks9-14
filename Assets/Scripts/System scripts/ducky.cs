using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ducky : MonoBehaviour
{
    public GameObject duckduck;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void bangbang() // public void so i can call this through inspector
    {
        Destroy(duckduck); // destroy gameobject when called upon
    }
}
