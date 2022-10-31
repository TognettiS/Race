using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LapsPlayer: MonoBehaviour
{
  public Animator SceneTransition;
  public Text Laps;
  int check = 0;
  int lap = 0;

    void Start()
    {

    }

    void OnTriggerEnter(Collider other)
    {
      switch (other.gameObject.name) {
        case "Finish Line":
        if (check == 7) {
          check = 0;
          lap += 1;
          Laps.text = "Lap: 2/2";
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
        case "Check Point 3":
          if (check == 2) {
            check = 3;
            break;
          }
          break;
        case "Check Point 4":
          if (check == 3) {
            check = 4;
            break;
            }
          break;
        case "Check Point 5":
          if (check == 4) {
            check = 5;
            break;
            }
          break;
        case "Check Point 6":
          if (check == 5) {
            check = 6;
            break;
            }
          break;
        case "Check Point 7":
          if (check == 6) {
            check = 7;
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
        SceneManager.LoadScene("Win");

    }
}
