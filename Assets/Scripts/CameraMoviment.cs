using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMoviment : MonoBehaviour
{
    public Transform target; // O objeto ao redor do qual a câmera vai girar
    public float rotationSpeed = 5.0f; // Velocidade de rotação
    private Vector3 offset;

    private bool canInput = false;

    public GameManager gameManager;

    private void Start()
    {

        gameManager = FindAnyObjectByType<GameManager>();
        gameManager.GameStateChanged += OnGameStateChanged;
        offset = transform.position - target.position; // Calcula a movimentção da câmera em relação ao objeto
    }

    void Update()
    {
        // Verifique se o botão direito do mouse está pressionado
        if (Input.GetMouseButton(1) && canInput)
        {
            // Captura as mudanças no movimento do mouse
            float mouseX = Input.GetAxis("Mouse X") * rotationSpeed;

            // Rotaciona o objeto alvo
            target.Rotate(Vector3.down, mouseX);

            // Mantenha a posição da câmera em relação ao objeto
            transform.position = target.position + offset;
        }
    }

    public void OnGameStateChanged(GameManager.GameState state) {
        Debug.Log(state.ToString());
        if (state == GameManager.GameState.PLAYING)
        {
            canInput = true;
        }
        else
        {
            canInput = false;
        }
    }
}
