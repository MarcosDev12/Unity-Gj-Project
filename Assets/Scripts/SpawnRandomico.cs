using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnRandomico : MonoBehaviour
{
    public GameObject[] objectsToActivate; // Array contendo os 10 objetos que voc� deseja tornar vis�veis
    public float visibilityDelay = 5.0f; // Tempo em segundos at� um novo objeto ser ativado
    private int currentlyActiveObjectIndex = -1;

    void Start()
    {
        // Certifique-se de que todos os objetos estejam inativos no in�cio
        foreach (var obj in objectsToActivate)
        {
            obj.SetActive(false);
        }

        // Inicie a rotina para ativar objetos aleat�rios
        StartCoroutine(ActivateRandomObjects());
    }

    IEnumerator ActivateRandomObjects()
    {
        while (true) // Isso far� com que a rotina se repita indefinidamente
        {
            int randomIndex;
            do
            {
                randomIndex = Random.Range(0, objectsToActivate.Length);
            } while (randomIndex == currentlyActiveObjectIndex); // Garante que o objeto escolhido n�o seja o mesmo do atualmente ativo

            currentlyActiveObjectIndex = randomIndex;
            objectsToActivate[randomIndex].SetActive(true);

            // Aguarde o tempo de atraso antes de ativar o pr�ximo objeto
            yield return new WaitForSeconds(visibilityDelay);
        }
    }
}
