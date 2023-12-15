using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float velocidadRotacion = 200f; // Agrega esta línea para definir la velocidad de rotación

    void Update()
    {
        // Obtener la entrada de rotación (por ejemplo, las teclas de flecha)
        float rotationInput = Input.GetAxis("Horizontal");

        // Aplicar la rotación al jugador
        transform.Rotate(Vector3.forward * rotationInput * Time.deltaTime * velocidadRotacion);
    }
}
