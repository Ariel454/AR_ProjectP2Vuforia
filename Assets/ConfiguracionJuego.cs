using UnityEngine;
public class ConfiguracionJuego : MonoBehaviour
{
    public int cantidadEnemigosPermitidos = 2;
    public int limiteBasuraPorTipoPermitido = 3;

    public bool juegoReiniciado = false;

    private void Awake()
    {
        // Asegura que el objeto no se destruya al cargar una nueva escena
        DontDestroyOnLoad(gameObject);
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
    }
}
