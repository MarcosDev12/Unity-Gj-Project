using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMoviment : MonoBehaviour
{
    public Transform target; // O objeto ao redor do qual a c�mera vai girar
    public float rotationSpeed = 5.0f; // Velocidade de rota��o
    private Vector3 offset;

    private void Start()
    {
        offset = transform.position - target.position; // Calcula a moviment��o da c�mera em rela��o ao objeto
    }

    void Update()
    {
        // Verifique se o bot�o direito do mouse est� pressionado
        if (Input.GetMouseButton(1))
        {
            // Captura as mudan�as no movimento do mouse
            float mouseX = Input.GetAxis("Mouse X") * rotationSpeed;

            // Rotaciona o objeto alvo
            target.Rotate(Vector3.down, mouseX);

            // Mantenha a posi��o da c�mera em rela��o ao objeto
            transform.position = target.position + offset;
        }
    }
}
