using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpecialAct : MonoBehaviour
{
    Text text;

    private void Awake()
    {
        text = GameObject.FindGameObjectWithTag("text2").GetComponent<Text>();
    }

    public void TextoOn()
    {
        text.SetTextOn();
    }
}
