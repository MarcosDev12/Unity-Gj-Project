using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnRandomico : MonoBehaviour
{
    public GameObject[] objectsToActivate; // Array contendo os 10 objetos que você deseja tornar visíveis
    public float visibilityDelay = 5.0f; // Tempo em segundos até um novo objeto ser ativado
    private int currentlyActiveObjectIndex = -1;

    void Start()
    {
        // Certifique-se de que todos os objetos estejam inativos no início
        foreach (var obj in objectsToActivate)
        {
            obj.SetActive(false);
        }

        // Inicie a rotina para ativar objetos aleatórios
        StartCoroutine(ActivateRandomObjects());
    }

    IEnumerator ActivateRandomObjects()
    {
        while (true) // Isso fará com que a rotina se repita indefinidamente
        {
            int randomIndex;
            do
            {
                randomIndex = Random.Range(0, objectsToActivate.Length);
            } while (randomIndex == currentlyActiveObjectIndex); // Garante que o objeto escolhido não seja o mesmo do atualmente ativo

            currentlyActiveObjectIndex = randomIndex;
            objectsToActivate[randomIndex].SetActive(true);

            // Aguarde o tempo de atraso antes de ativar o próximo objeto
            yield return new WaitForSeconds(visibilityDelay);
        }
    }
}
