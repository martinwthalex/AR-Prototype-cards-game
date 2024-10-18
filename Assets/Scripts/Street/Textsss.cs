using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Textsss : MonoBehaviour
{
    private TMP_Text _text;
    [SerializeField] int _lineCount = 0;
    float time = 0;

    private void Awake()
    {
        _text = GetComponent<TMP_Text>();
    }

    void Start()
    {
        if (_lineCount == 0)
        {
            _text.text = ("Welcome to Sesame Street!");
        }
        if (_lineCount == 5)
        {
            _text.text = ("Try asking some of my friends what they need");
        }
        Wait();
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0) && _lineCount == 1 && time > 0.4f)
        {
            _text.text = ("Things aren´t looking very good here...");
            Wait();
        }
        if (Input.GetMouseButtonDown(0) && _lineCount == 2 && time > 0.4f)
        {
            _text.text = ("Contamination has made my friends sick");
            Wait();
        }
        if (Input.GetMouseButtonDown(0) && _lineCount == 3 && time > 0.4f)
        {
            _text.text = ("Could you help me better the environment?");
            Wait();
        }
        if (Input.GetMouseButtonDown(0) && _lineCount == 4 && time > 0.4f)
        {
            _text.text = ("I think together we can fix this mess and make them feel better!");
            Wait();
        }
        if (Input.GetMouseButtonDown(0) && _lineCount == 5 && time > 0.4f)
        {
            gameObject.SetActive(false);
            transform.parent.gameObject.SetActive(false);
            _text.text = ("Try asking some of my friends what they need");
            Wait();
        }
        if (Input.GetMouseButtonDown(0) && _lineCount == 6 && time > 0.4f)
        {
            Wait2();
        }

        time += Time.deltaTime;

    }

    void Wait()
    {
        time = 0;
        _lineCount++;
    }

    void Wait2()
    {
        time = 0;
        _lineCount--;
    }

    public void SetTextOn()
    {
        gameObject.SetActive(true);
        transform.parent.gameObject.SetActive(true);
    }
}
