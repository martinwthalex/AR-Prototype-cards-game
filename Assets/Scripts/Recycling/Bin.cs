using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bin : MonoBehaviour
{
    private Left text;

    private void Start()
    {
        text = GameObject.FindGameObjectWithTag("text").GetComponent<Left>();
    }

    private void Update()
    {
        text = GameObject.FindGameObjectWithTag("text").GetComponent<Left>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == gameObject.tag)
        {
            text._objects--;
            Destroy(collision.gameObject);
        }
    }
}
