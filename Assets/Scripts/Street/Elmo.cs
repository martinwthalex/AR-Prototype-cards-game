using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Elmo : MonoBehaviour
{

    Textsss text;

    private void Start()
    {
        text = GameObject.FindGameObjectWithTag("text").GetComponent<Textsss>();
    }

    public void TextoOn()
    {
        text.SetTextOn();
    }
}
