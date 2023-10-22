using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class Test : MonoBehaviour
{
    public GameObject MinegameOff;

    public void OnMouseDown()
    {
        ClickOff();
    }

    public void ClickOff()
    {
        MinegameOff.gameObject.SetActive(false);
    }
}
