using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class clock : MonoBehaviour
{
    public Transform hourH;
    public Transform minuteH;

    public float hourDuration = 5;
    public float t;

    public int hour = 0;

    public UnityEvent<int> onHour;

    Coroutine runrun;
    IEnumerator aSingleHour;

    // Start is called before the first frame update
    void Start()
    {
       runrun = StartCoroutine(moveClock());
    }

    // Update is called once per frame
    //id Update()
   //    t += Time.deltaTime;

       //f (t > hourDuration)
     // {
     //     t = 0;
  //        onHour.Invoke();
  //    }

 //     if (hour == 12)
  //    {
       //   hour = 0;
  //    }
   //

    private IEnumerator moveHands()
    {
        t = 0;

        while (t < hourDuration)
        {
            t += Time.deltaTime;
            minuteH.Rotate(0, 0, -(360 / hourDuration) * Time.deltaTime);
            hourH.Rotate(0, 0, -(30 / hourDuration) + Time.deltaTime);
            yield return null;
        }

     // onHour.Invoke();
    }

    private IEnumerator moveClock()
    {
        while (true)
        {
            aSingleHour = moveHands();

            yield return StartCoroutine(moveHands());
        }
    }

    public void stopClock()
    {
        if(runrun != null)
        {
            StopCoroutine(runrun);
        }
        
        if (aSingleHour != null)
        {
            StopCoroutine(aSingleHour);
        }
        
    }

}
