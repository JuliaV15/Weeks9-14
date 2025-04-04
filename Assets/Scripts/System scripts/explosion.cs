using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class explosion : MonoBehaviour
{
    AudioClip explosiondotcom;
    AudioSource AAAAAAAAAA;

    // Start is called before the first frame update
    void Start()
    {
        AAAAAAAAAA = GetComponent<AudioSource>(); // calling the audio source component in the inspector
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void bigboom()
    {
        AAAAAAAAAA.Play(); // play the audio clip sound 
    }
}
