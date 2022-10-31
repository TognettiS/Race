using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Positions : MonoBehaviour
{
    public Text Placement;
    public GameObject Player;
    public GameObject Bot1;
    public GameObject Check1;
    public GameObject Check2;
    public GameObject Check3;
    public GameObject Check4;
    public GameObject Check5;
    public GameObject Check6;
    public GameObject Check7;
    public GameObject FinishLine;
    float distPlayer;
    float distBot01;
    float x;

    void Start()
    {
      x = 1;
    }

    void OnTriggerEnter(Collider other)
    {
      switch (other.gameObject.name) {
        case "Check Point 1":
          x = 2;
          break;
        case "Check Point 2":
          x = 3;
          break;
        case "Check Point 3":
          x = 4;
          break;
        case "Check Point 4":
          x = 5;
          break;
        case "Check Point 5":
          x = 6;
          break;
        case "Check Point 6":
          x = 7;
          break;
        case "Check Point 7":
          x = 8;
          break;
        case "Finish Line":
          x = 1;
          break;
      }

    }

    void Update()
    {
        CreateDist();
        CheckDistance(distPlayer, distBot01);
    }

void CreateDist()
{
  switch (x) {
    case 1:
      distPlayer = Vector3.Distance(Player.transform.position, Check1.transform.position);
      distBot01 = Vector3.Distance(Bot1.transform.position, Check1.transform.position);
      break;
    case 2:
      distPlayer = Vector3.Distance(Player.transform.position, Check2.transform.position);
      distBot01 = Vector3.Distance(Bot1.transform.position, Check2.transform.position);
      break;
    case 3:
      distPlayer = Vector3.Distance(Player.transform.position, Check3.transform.position);
      distBot01 = Vector3.Distance(Bot1.transform.position, Check3.transform.position);
      break;
    case 4:
      distPlayer = Vector3.Distance(Player.transform.position, Check4.transform.position);
      distBot01 = Vector3.Distance(Bot1.transform.position, Check4.transform.position);
      break;
    case 5:
      distPlayer = Vector3.Distance(Player.transform.position, Check5.transform.position);
      distBot01 = Vector3.Distance(Bot1.transform.position, Check5.transform.position);
      break;
    case 6:
      distPlayer = Vector3.Distance(Player.transform.position, Check6.transform.position);
      distBot01 = Vector3.Distance(Bot1.transform.position, Check6.transform.position);
      break;
    case 7:
      distPlayer = Vector3.Distance(Player.transform.position, Check7.transform.position);
      distBot01 = Vector3.Distance(Bot1.transform.position, Check7.transform.position);
      break;
    case 8:
      distPlayer = Vector3.Distance(Player.transform.position, FinishLine.transform.position);
      distBot01 = Vector3.Distance(Bot1.transform.position, FinishLine.transform.position);
      break;
  }
}
void CheckDistance(float distPlayer, float distBot01){
      if (distPlayer < distBot01) {
        Placement.text = "1st";
      }
      else {
        Placement.text = "2nd";
      }
    }
}
