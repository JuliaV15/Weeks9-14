﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class forking : MonoBehaviour
{
    public RectTransform latina;
    public UnityEvent urmom;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void corn()
    {
        Debug.Log("( ͡° ͜ʖ ͡°)");
        latina.localScale = Vector3.one * 2f;
    }

    public void cob()
    {
        Debug.Log("🌽🌽🌽");
        latina.localScale = Vector3.one;
    }
}
