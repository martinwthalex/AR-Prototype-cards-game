using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElmoGall : MonoBehaviour
{
    Text text;

    private void Awake()
    {
        text = GameObject.FindGameObjectWithTag("text").GetComponent<Text>();
    }

    public void TextoOn()
    {
        text.SetTextOn();
    }
}
