using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float velocidadRotacion = 200f; // Agrega esta l�nea para definir la velocidad de rotaci�n

    void Update()
    {
        // Obtener la entrada de rotaci�n (por ejemplo, las teclas de flecha)
        float rotationInput = Input.GetAxis("Horizontal");

        // Aplicar la rotaci�n al jugador
        transform.Rotate(Vector3.forward * rotationInput * Time.deltaTime * velocidadRotacion);
    }
}
