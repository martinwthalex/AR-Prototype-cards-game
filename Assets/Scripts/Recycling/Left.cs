using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class Left : MonoBehaviour
{
    private TMP_Text _left;
    private string Texto;
    public int _objects = 10;


    private void Awake()
    {
        _left = GetComponent<TMP_Text>();
    }

    void Update()
    {
        Texto = ("Left: " + _objects);
        _left.text = Texto;

        if(_objects == 0)
        {
                SceneManager.LoadScene("SesameStreet1");
        }
    }

    public void DeleteObject()
    {
        _objects--;
    }

}