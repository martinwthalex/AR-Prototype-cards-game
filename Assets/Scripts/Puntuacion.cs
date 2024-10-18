using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class Puntuacion : MonoBehaviour
{
    public TMP_Text textoPuntuacion;
    string texto;
    public int puntosNecesarios = 15;

    private int puntuacion = 0;

    private void Start()
    {
        texto = "Puntuación: " + puntuacion + "/" + puntosNecesarios;
        textoPuntuacion.text = texto;
    }

    private void ActualizarPuntuacion()
    {
        texto = "Puntuación: " + puntuacion + "/" + puntosNecesarios;
        textoPuntuacion.text = texto;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Basura"))
        {
            puntuacion++;
            Destroy(collision.gameObject);
            ActualizarPuntuacion();
            if (puntuacion >= puntosNecesarios)
            {
                SceneManager.LoadScene("SesameStreet1");
            }

        }
    }





}



