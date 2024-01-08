using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CañonController : MonoBehaviour
{
    public GameObject cañon;
    public GameObject bolitaPrefab;
    public float velocidadDisparo = 10f;
    public Button botonDisparar;  // Asigna el botón desde el Inspector

    void Start()
    {
        // Agrega un listener al evento de clic del botón
        if (botonDisparar != null)
        {
            botonDisparar.onClick.AddListener(Disparar);
        }
        else
        {
            Debug.LogError("El botón de disparo no está asignado en el Inspector.");
        }
    }

    void Update()
    {
        // Aquí puedes realizar otras operaciones de actualización si es necesario
    }

void Disparar()
{
    // Obtiene la posición y rotación del cañón para depuración
    Vector3 posicionCañon = cañon.transform.position;
    Quaternion rotacionCañon = cañon.transform.rotation;

    Debug.Log("Posición del Cañón: " + posicionCañon);
    Debug.Log("Rotación del Cañón: " + rotacionCañon.eulerAngles);

    // Instancia una bolita en la posición y rotación del cañón
    GameObject bolita = Instantiate(bolitaPrefab, posicionCañon, rotacionCañon);

    // Aplica velocidad a la bolita en la dirección hacia adelante del cañón
    bolita.GetComponent<Rigidbody>().velocity = -cañon.transform.up * velocidadDisparo;

    // Destruye la bolita después de 3 segundos
    Destroy(bolita, 3f);
}

}
