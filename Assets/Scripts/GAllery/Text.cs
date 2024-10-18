using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Text : MonoBehaviour
{
    private TMP_Text _text;
    float time = 0;

    private void Awake()
    {
        _text = GetComponent<TMP_Text>();
        time = 0;
    }

    private void Start()
    {
        gameObject.SetActive(false);
        transform.parent.gameObject.SetActive(false);
    }

    void Update()
    {

        time += Time.deltaTime;
    }

    public void SetTextOn()
    {
        gameObject.SetActive(true);
        transform.parent.gameObject.SetActive(true);
        time = 0;
    }
}
