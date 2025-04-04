using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ducky : MonoBehaviour
{
    public GameObject duckduck;
    
    Coroutine bigboom;

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
       
        bigboom = StartCoroutine(biggerboom());

        Debug.Log("BOOM POW ZAP SIZZLE");
    }

    IEnumerator biggerboom ()
    {
      //  while (AAAAAAAAAA.isPlaying)
       // {
          //  yield return null;
       // }

        Destroy(duckduck); // destroy gameobject when called upon

        Debug.Log("duckduck exploded :(");
        yield return null;

    }
}
