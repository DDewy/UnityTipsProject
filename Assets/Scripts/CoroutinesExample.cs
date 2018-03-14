using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoroutinesExample : MonoBehaviour
{
    public bool UseStart = false;
    IEnumerator Start ()
    {
        if(!UseStart)
        {
            StartCoroutine(GameTimeCounter(1.0f));
            //yield break, stops the code here and exits from the Coroutine
            yield break;
        }
            

        while(true)
        {
            Debug.Log("The Game has been runing for " + Time.time + " seconds");
            //yield return takes what value you pass and waits that amount of time, returning null makes it wait for the next frame. 
            yield return new WaitForSeconds(1.0f);
        }
	}

    IEnumerator GameTimeCounter(float intervalTime)
    {
        while (true)
        {
            Debug.Log("The Game has been runing for " + Time.time + " seconds");
            yield return new WaitForSeconds(intervalTime);
        }
    }
}
