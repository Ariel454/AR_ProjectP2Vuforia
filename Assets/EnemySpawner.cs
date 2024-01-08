using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject enemigoPrefab;
    public GameObject botellaPrefab;
    public GameObject bloquePrefab;
    public GameObject pilaPrefab;

    //public int cantidadEnemigos = 4;  // Cambiado a cantidad fija
    //public int limiteBasuraPorTipo = 5;

    private int enemigosInstanciados = 0;
    private int basuraInstanciada = 0;

    // Tag para identificar el tablero
    private string tableroTag = "tablero";

    void Start()
    {
        InstanciarEnemigos();  // Llama a la función al inicio para instanciar los enemigos de inmediato
        InstanciarBasura();    // Llama a la función al inicio para instanciar la basura de inmediato
    }

void InstanciarEnemigos()
    {
        // Busca el objeto del tablero usando el tag
                int cantidadEnemigos = FindObjectOfType<GameManager>().cantidadEnemigosPermitidos;

        GameObject tablero = GameObject.FindGameObjectWithTag(tableroTag);

        if (tablero != null)
        {
            // Itera para crear la cantidad de enemigos especificada
            for (int i = 0; i < cantidadEnemigos; i++)
            {
                // Genera posiciones aleatorias dentro de los rangos especificados
                float posX = Random.Range(-0.1f, 0.1f);
                float posZ = Random.Range(-0.07f, 0.07f);

                // Asegura que Y sea estrictamente 0
                float posY = 0f;

                // Instancia el enemigo con la posición y rotación deseadas
                Vector3 posicionEnemigo = new Vector3(posX, posY, posZ);
                GameObject nuevoEnemigo = Instantiate(enemigoPrefab, posicionEnemigo, Quaternion.identity);

                // Establece el tablero como el padre del nuevo enemigo
                nuevoEnemigo.transform.SetParent(tablero.transform);

                // Imprime información detallada en la consola para depuración
                Debug.Log("Nuevo enemigo instanciado en posición: " + nuevoEnemigo.transform.position);
                Debug.Log("Padre del nuevo enemigo: " + nuevoEnemigo.transform.parent.name);

                // Incrementa el contador de enemigos instanciados
                enemigosInstanciados++;
            }
        }
        else
        {
            Debug.LogError("No se encontró el objeto del tablero con el tag " + tableroTag);
        }
    }

    void InstanciarBasura()
    {
        // Busca el objeto del tablero usando el tag
        GameObject tablero = GameObject.FindGameObjectWithTag(tableroTag);
        int limiteBasuraPorTipo = FindObjectOfType<GameManager>().limiteBasuraPorTipoPermitido;

        if (tablero != null)
        {
            // Itera para crear la cantidad de basura especificada por tipo
            for (int i = 0; i < limiteBasuraPorTipo; i++)
            {
                InstanciarBasuraTipo(botellaPrefab, tablero);
                InstanciarBasuraTipo(bloquePrefab, tablero);
                InstanciarBasuraTipo(pilaPrefab, tablero);
            }
        }
        else
        {
            Debug.LogError("No se encontró el objeto del tablero con el tag " + tableroTag);
        }
    }

    void InstanciarBasuraTipo(GameObject prefab, GameObject tablero)
    {
        // Genera posiciones aleatorias dentro de los rangos especificados
        float posX = Random.Range(-0.1f, 0.1f);
        float posZ = Random.Range(-0.07f, 0.07f);

        // Asegura que Y sea estrictamente 0
        float posY = 0f;

        // Instancia la basura con la posición y rotación deseadas
        Vector3 posicionBasura = new Vector3(posX, posY, posZ);
        GameObject nuevaBasura = Instantiate(prefab, posicionBasura, Quaternion.identity);

        // Establece el tablero como el padre de la nueva basura
        nuevaBasura.transform.SetParent(tablero.transform);

        // Imprime información detallada en la consola para depuración
        Debug.Log("Nueva basura instanciada en posición: " + nuevaBasura.transform.position);
        Debug.Log("Padre de la nueva basura: " + nuevaBasura.transform.parent.name);

        // Incrementa el contador de basura instanciada
        basuraInstanciada++;
    }
}
