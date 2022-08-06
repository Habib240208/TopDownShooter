using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Chronometer : MonoBehaviour
{
    float timer;
    public Text timerText;

    //Update is called once per frame
     void Update()
    {
        timer += Time.deltaTime;
        timerText.text = timer.ToString();
        timerText.text = Mathf.Floor(timer).ToString();
    }
}
