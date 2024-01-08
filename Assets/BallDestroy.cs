using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallDestroy : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
{
    // Verifica si el objeto que colisionó tiene el tag "caja"
    if (other.CompareTag("Enemy"))
    {
        // Destruye el objeto que tiene el collider "caja"
        Destroy(other.gameObject);
        Debug.Log("Enemigo Destruido");
    }


}
}
