using UnityEngine;

public class ControladorNaveConJoystick : MonoBehaviour
{
    public float velocidad = 0.01f;  
    public float velocidadRotacion = 1f;
    public VariableJoystick joystick;
    public VariableJoystick joystickRotacion;

    void Update()
    {
        // Obtiene la dirección del joystick
        Vector3 direccion = new Vector3(joystick.Horizontal, 0f, joystick.Vertical);

        // Mueve la nave solo en los ejes X y Z
        transform.Translate(new Vector3(direccion.x, 0f, direccion.z) * velocidad * Time.deltaTime);

        // Obtiene la dirección del joystick para la rotación en el eje Y
        float direccionRotacionY = joystickRotacion.Horizontal;

        // Aplica la rotación a la nave en el eje Y
        transform.Rotate(Vector3.up, direccionRotacionY * velocidadRotacion * Time.deltaTime);
        Debug.Log("Direccion de Rotacion Y: " + direccionRotacionY);
    }
}
