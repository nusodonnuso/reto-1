using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class Score : MonoBehaviour
{
    private int Puntaje = 0;
    private int PUNTOS_OBJETIVO = 15;
    public GameObject ObjetoActivar;
    public TMP_Text scoreT;


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Puntos"))
        {
            Destroy(other.gameObject);
            Puntaje++;
            scoreT.text = "Score: " + Puntaje;
            SumarPuntos(1);
        }
    }
    public void SumarPuntos(int cantidad)
    {
        if (Puntaje >= PUNTOS_OBJETIVO)
        {
            ObjetoActivar.SetActive(true);

            Debug.Log("Objetivo alcanzado");
        }
    }
}
