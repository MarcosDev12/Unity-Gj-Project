using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeScript : MonoBehaviour
{
    public Sprite novoSprite; // Arraste o novo sprite desejado para esta variável no Inspector

    private void OnMouseDown()
    {
        TrocarSprite();
    }

    private void TrocarSprite()
    {
        if (novoSprite != null)
        {
            GetComponent<SpriteRenderer>().sprite = novoSprite;
        }
        else
        {
            Debug.LogWarning("O novo sprite não foi atribuído no Inspector.");
        }
    }
}
