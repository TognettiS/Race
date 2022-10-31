using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LapsBots: MonoBehaviour
{
  public Animator SceneTransition;
  int check = 0;
  int lap = 0;

    void Start()
    {

    }

    void OnTriggerEnter(Collider other)
    {
      switch (other.gameObject.name) {
        case "Finish Line":
        if (check == 2) {
          check = 0;
          lap += 1;
          if (lap == 2) {
            StartCoroutine(Lap());
          }
          break;
        }
        else {
          check = 0;
          break;
        }
        case "Check Point 1":
          check = 1;
          break;
        case "Check Point 2":
          if (check == 1) {
            check = 2;
            break;
          }
          break;
      }
    }

    void Update()
    {

    }

    IEnumerator Lap()
    {
      SceneTransition.SetTrigger("Start");
      yield return new WaitForSecondsRealtime(1);
      SceneManager.LoadScene("Lose");
    }
}
