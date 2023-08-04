using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Vidas : MonoBehaviour
{
    //Variable que almacena la vida total durante la partida
    public int VidaTotal;
    private void Start()
    {
        //Inicializa el texto del canvas con la vida total
        gameObject.GetComponent<TextMeshProUGUI>().text = VidaTotal.ToString();
    }
    public void CondicionesVida()
    {
        if (VidaTotal <= 0)
        {
            //La vida total no puede ser menor a cero
            VidaTotal = 0;
            //Actualizar el texto del canvas con la vida total
            gameObject.GetComponent<TextMeshProUGUI>().text = VidaTotal.ToString();
            //Mostrar PanelPerder
            GameObject.FindObjectOfType<Paneles>().panelPerder.SetActive(true);
        }
    }
}
