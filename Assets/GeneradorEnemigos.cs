using UnityEngine;

public class GeneradorEnemigos : MonoBehaviour
{
    public GameObject esqueletoPrefab;
    public int cantidadEnemigos = 5;
    public float rangoGeneracion = 1f;  // Ajusta según tu necesidad

    void Start()
    {
        GenerarEnemigos();
    }

    void GenerarEnemigos()
    {
        for (int i = 0; i < cantidadEnemigos; i++)
        {
            float posicionX = Random.Range(0f, rangoGeneracion);
            float posicionZ = Random.Range(0f, rangoGeneracion);
            
            Vector3 posicionAleatoria = new Vector3(posicionX, 0f, posicionZ);
            Instantiate(esqueletoPrefab, posicionAleatoria, Quaternion.identity);
        }
    }
}
