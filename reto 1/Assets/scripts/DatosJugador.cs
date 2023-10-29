using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DatosJugador : MonoBehaviour
{
    public int vidaPlayer;
    public Slider vidaVisual;
    public GameObject panelGameOver; // Referencia al panel de Game Over

    private void Start()
    {
        panelGameOver.SetActive(false); // Asegúrate de que el panel esté desactivado al inicio del juego
    }

    private void Update()
    {
        vidaVisual.value = vidaPlayer; // No es necesario usar GetComponent aquí

        if (vidaPlayer <= 0)
        {
            // Aquí activamos el panel de Game Over y detenemos el juego
            panelGameOver.SetActive(true);
            /*
            Time.timeScale = 0; // Esto detendrá el tiempo en el juego, pausándolo
            */
        }
    }
}