using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    private bool isPaused = false;
    public GameObject pauseMenu;
    public int cantidadEnemigosPermitidos;
    public int limiteBasuraPorTipoPermitido;

    public bool juegoReiniciado = false;


void Awake()
{

            // Asegura que el objeto no se destruya al cargar una nueva escena
        DontDestroyOnLoad(gameObject);

    if(juegoReiniciado==false){
        cantidadEnemigosPermitidos = 2;
        limiteBasuraPorTipoPermitido = 3;
    }else{
        Time.timeScale = 1;
        cantidadEnemigosPermitidos = 7;
        limiteBasuraPorTipoPermitido = 6;
    }


        Debug.Log("Cantidad inicial"+cantidadEnemigosPermitidos+"Cantindad inciial 2: "+limiteBasuraPorTipoPermitido);

}


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            TogglePause();
        }
    }

    public void TogglePause()
    {
        isPaused = !isPaused;

        if (isPaused)
        {
            Time.timeScale = 0; // Pausa el tiempo en el juego
            pauseMenu.SetActive(true); // Muestra el menú de pausas
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
        }
        else
        {
            Time.timeScale = 1; // Reanuda el tiempo en el juego
            pauseMenu.SetActive(false); // Oculta el menú de pausa
        }
    }

    public void ResumeGame()
    {
        isPaused = false;
        Time.timeScale = 1; // Reanuda el tiempo en el juego
        pauseMenu.SetActive(false); // Oculta el menú de pausa
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    public void LoadScene(string sceneName){
        SceneManager.LoadScene(sceneName);
        Time.timeScale = 1.0f;
    }




public void ReiniciarJuego()
    {
        // Restablece las configuraciones solo si el juego no se ha reiniciado previamente
        if (!juegoReiniciado)
        {
            cantidadEnemigosPermitidos = 7;
            limiteBasuraPorTipoPermitido = 6;

            // Marca el juego como reiniciado
            juegoReiniciado = true;
        }

        Debug.Log("Cantidad de enemigos: " + cantidadEnemigosPermitidos + " | Limite de basura por tipo: " + limiteBasuraPorTipoPermitido);

    // Reinicia la escena
    Time.timeScale = 1;
    SceneManager.LoadScene(SceneManager.GetActiveScene().name);
}





}