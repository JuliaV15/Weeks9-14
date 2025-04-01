using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Tilemaps;

public class codinggymthing : MonoBehaviour
{
    public GameObject meeple;
    public heroKnight morple;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 pos = Camera.main.ScreenToWorldPoint(Input.mousePosition); // makes knight appear where mouse pos is when i hit spacebar
        if (Input.GetKeyDown(KeyCode.Space))
        {
            morple.transform.position = pos;
        }
       
       //Tilemap 
    }
}
