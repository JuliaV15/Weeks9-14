using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class demoEvent : MonoBehaviour
{
    public RectTransform monkeydluffy;
    public UnityEvent YourTimeHasCome;
    public float timerLength = 2;
    public float t;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        t += Time.deltaTime;
        if (t > timerLength)
        {
            t = 0;
            YourTimeHasCome.Invoke();
        }
    }

    public void ButtonMasherDotCom()
    {
        Debug.Log("Buttom Mashed Dot Com");
    }

    public void IClickedTheButtonNormally()
    {
        Debug.Log("I am not a weirdo, I didn't mash the button I just clicked it");
    }

    public void GeronimoStilton()
    {
        Debug.Log("GERONIMO!");
        monkeydluffy.localScale = Vector3.one * 1.2f;
    }
    public void GeronimoStiltonsKneecaps()
    {
        Debug.Log("I've stolen your kneecaps Geronimo.");
        monkeydluffy.localScale = Vector3.one;
    }
}
