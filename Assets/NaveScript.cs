using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class NaveScript : MonoBehaviour
{
    public TextMeshProUGUI capacidadText;
    public GameObject mensajeGanador;
    public GameObject basuraTexto;
    public TextMeshProUGUI BasuraRestante;
    public GameObject textoGameOverParent;
    public TMPro.TextMeshProUGUI TextoGameOver;
    public int capacidadMaxima = 5;
    public float vidaTotal = 1.0f;
    float vidaActual; // Variable para almacenar la vida actual
    public Image barraVida; 
    private int basuraRecogida = 0;

    private int capacidadActual = 0;

    private int totalBasura=0;


    void Start()
    {
        ActualizarTextoCapacidad();
        
        Debug.Log("TOtal basura:"+totalBasura);
        mensajeGanador.gameObject.SetActive(false); 
    }

    void Update()
    {
    }


    private void OnTriggerEnter(Collider other)
    {
        // Verifica si el objeto que colisionó tiene el tag "basura"
        if (other.CompareTag("basura"))
        {
            if(totalBasura==0){
            totalBasura = GameObject.FindGameObjectsWithTag("basura").Length;
            Debug.Log("TOtal basura:"+totalBasura);
            basuraTexto.gameObject.SetActive(true);
            BasuraRestante.text = "Basura a recoger: " + totalBasura;
            ActualizarTextoCapacidad();
            }
            

            // Verifica si la capacidad no ha alcanzado el límite
            if (capacidadActual < capacidadMaxima)
            {
                // Incrementa la capacidad y destruye el objeto de basura
                capacidadActual++;
                Destroy(other.gameObject);
                Debug.Log("Caja recogida. Capacidad Actual: " + capacidadActual);

                // Actualiza el texto en el Canvas
                ActualizarTextoCapacidad();
            }
            else
            {
                Debug.Log("La capacidad está llena. No se puede recoger más basura.");
            }

            
        }
        else if (other.CompareTag("camion"))
        {
            // Verifica si estás cerca del camión para reiniciar la capacidad
            if (Vector3.Distance(transform.position, other.transform.position) < 2f)
            {
                basuraRecogida=capacidadActual+basuraRecogida;
                capacidadActual = 0;
                Debug.Log("Capacidad reiniciada. Puedes recoger más basura.");
                ActualizarTextoCapacidad();


                Debug.Log("Basura Recogida: "+basuraRecogida);
                // Verifica si se ha recogido toda la basura
                if (basuraRecogida >= totalBasura)
                {
                    // Muestra el mensaje de ganador
                    MostrarTextoWin();
                }
            }
        }
        else if (other.CompareTag("Enemy"))
        {
            Debug.Log("Daño");
            RecibirDanio();
        }
    }

    void ActualizarTextoCapacidad()
    {
        if (capacidadText != null)
        {
            capacidadText.text = "Capacidad: " + capacidadActual + "/" + capacidadMaxima;
        }
    }

    void RecibirDanio()
    {   
        if(vidaTotal != 0){
            vidaTotal = vidaTotal-0.2f;
            barraVida.fillAmount = vidaTotal;     
            if(vidaTotal <= 0.0001f){
                MostrarTextoGameOver();
            }
        }

    }

    void MostrarTextoGameOver()
    {
        // Activa el objeto de juego que contiene el TextMeshProUGUI
        textoGameOverParent.SetActive(true);
        Time.timeScale = 0f;
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
        
    }

        void MostrarTextoWin()
    {
        // Activa el objeto de juego que contiene el TextMeshProUGUI
        mensajeGanador.gameObject.SetActive(true);
        Time.timeScale = 0f;
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
        
    }
    
}
