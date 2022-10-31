using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer: MonoBehaviour
{
    public Behaviour playercar;
    public Behaviour botcar1;
    float tempoAtual = 5f;

    [SerializeField] Text temporizador;

    void Start()
    {
      playercar.enabled = false;
      botcar1.enabled = false;
    }

    void Update()
    {
      tempoAtual -= 1 * Time.deltaTime;
      temporizador.text = tempoAtual.ToString("0");
      if (tempoAtual <= 0) {
        Destroy(gameObject);
        playercar.enabled = true;
        botcar1.enabled = true;
      }
    }
}
