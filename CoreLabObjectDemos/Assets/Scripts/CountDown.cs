    using System.Collections;
    using System.Collections.Generic;
    using UnityEngine;
    using TMPro;

public class CountDown : MonoBehaviour
{
    public TextMeshPro timer; 
    public int timeLeft = 60; //Seconds Overall
    void Start()
    {
        StartCoroutine("LoseTime");
        Time.timeScale = 1; //Just making sure that the timeScale is right
    }

      void Update () {

        if(timeLeft >= 0){
          // timeLeft--;
          GetComponent<TextMeshPro>().text = ("" + timeLeft);
        } else {

        GetComponent<TextMeshPro>().text = ("You lost");
        }

      }

          //Simple Coroutine
      IEnumerator LoseTime()
      {
        while (timeLeft>0) {
          yield return new WaitForSeconds (1);
          timeLeft--; 
        }
      }
}


