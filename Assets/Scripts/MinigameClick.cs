using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class MinigameClick : MonoBehaviour
{
    public GameObject Minegame;

    private void OnMouseDown()
    {
        ClickOn();
    }

    public void ClickOn()
    {
        Minegame.gameObject.SetActive(true);
    }
}
