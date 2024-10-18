using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Reciclar : MonoBehaviour
{
    public void Recycle()
    {
        SceneManager.LoadScene("Recycle");
    }
}
