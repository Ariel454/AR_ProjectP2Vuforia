using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public float velocidad = 0.05f;
    private Transform jugador;

    void Start()
    {
        // Invoca la función IniciarPersecucion después de 3 segundos
        Invoke("IniciarPersecucion", 4f);
    }

    void IniciarPersecucion()
    {
        // Obtén la referencia al transform del jugador (nave)
        jugador = GameObject.FindGameObjectWithTag("Player").transform;
    }

    void Update()
    {
        // Si el jugador es nulo, no hagas nada
        if (jugador == null)
            return;

        // Calcula la dirección normalizada al jugador en todos los ejes
        Vector3 direccionAlJugador = (jugador.position - transform.position).normalized;

        // Mueve el enemigo hacia el jugador en todos los ejes
        transform.Translate(direccionAlJugador * velocidad * Time.deltaTime, Space.World);
    }

    public void ConfigurarJugador(Transform nuevoJugador)
    {
        jugador = nuevoJugador;
    }
}
