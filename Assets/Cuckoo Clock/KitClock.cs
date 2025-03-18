using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class KitClock : MonoBehaviour
{
    public float timeAnHourTakes = 5;

    public float t;
    public int hour = 0;

    public UnityEvent OnTheHour;

    void Update()
    {
        t += Time.deltaTime;

        if (t > timeAnHourTakes)
        {
            t = 0;
            OnTheHour.Invoke();

            hour++;
            if (hour == 12)
            {
                hour = 0;
            }
        }
    }
}
