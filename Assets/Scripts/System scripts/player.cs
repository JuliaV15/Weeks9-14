using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class player : MonoBehaviour
{
    public GameObject gorgonzola;
    public RectTransform growgrowfruit;
    public UnityEvent yffulDyeknom;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 pos = Input.mousePosition; // has the game object gorgonzola follow the mouse position
        gorgonzola.transform.position = pos;
    }

    public void growgrow()
    {
        growgrowfruit.localScale += Vector3.one * 0.5f;
        Debug.Log("omg it grew");
    }
}
