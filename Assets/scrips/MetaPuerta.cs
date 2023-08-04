using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MetaPuerta : MonoBehaviour
{
    public AudioClip puertaAuido;
    public AudioSource audioSource;


    public int puntajeMinimo;

    public bool evaluarPuntaje;


    private void OnTriggerEnter2D(Collider2D collision)
    {
        //Solo detecta colisiones del Player
        if (collision.CompareTag("Player"))
        {
            if (evaluarPuntaje)
            {
                //Encuentro el objeto Puntaje en el juego
                GameObject puntaje = GameObject.FindObjectOfType<Puntaje>().gameObject;
                //si el puntaje es cierto valor
                if (puntaje.GetComponent<Puntaje>().PuntajeTotal >= puntajeMinimo)
                {
                    audioSource.PlayOneShot(puertaAuido);
                    //ejecutar aniamcion "door"
                    gameObject.GetComponent<Animator>().Play("door");
                }
                else
                {
                    Debug.Log("Te faltan monedas por conseguir.");
                }
            }
            else
            {
                audioSource.PlayOneShot(puertaAuido);
                //ejecutar aniamcion "door"
                gameObject.GetComponent<Animator>().Play("door");

            }





        }
    }
    public void Destruir()
    {
        Destroy(gameObject);

    }
}
