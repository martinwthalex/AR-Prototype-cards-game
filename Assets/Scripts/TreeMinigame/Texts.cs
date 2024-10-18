using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
public class Texts : MonoBehaviour
{
    public TMP_Text text;
    int i = 0;
    public GameObject panel;
    // Start is called before the first frame update
    void Start()
    {
        text.text = "Hi, look at this beautiful tree!";
    }

    // Update is called once per frame
    void Update()
    {
        if(i <= 2) StartTexts();
        if(Manager.currentWateringCans >= Manager.MAX_WateringCans)
        {
            //print("eo");
            
            FinishWateringCans();
        }
        if (Manager.currentClickedClouds >= Manager.MAX_Clouds)
        {
            
            FinishRemovingClouds();
        }
    }
    void StartTexts()
    {
        if (Input.GetMouseButtonDown(0) && i == 0)
        {
            text.text = "You have to take care of him!";
            i++;
        }
        else if (Input.GetMouseButtonDown(0) && i==1)
        {
            text.text = "Start by clicking on those watering cans!";
            i++;
        }
        else if (Input.GetMouseButtonDown(0) && i == 2)
        {
            panel.SetActive(false);
            i++;
        }
    }
    public void FinishWateringCans()
    {
        if(i == 3)
        {
            panel.SetActive(true);
            
            text.text = "Great! Now your tree is healthy!";
            i++;
        }
        else if (Input.GetMouseButtonDown(0) && i == 4)
        {
            
            text.text = "The sun is hiding behind those clouds, can you remove them ?";
            i++;
        }
        else if (Input.GetMouseButtonDown(0) && i == 5)
        {
            
            panel.SetActive(false);
            
        }
    }
    public void FinishRemovingClouds()
    {
        if ( i == 5)
        {
            panel.SetActive(true);
            text.text = "Fantastic!";
            i++;
        }
        else if (Input.GetMouseButtonDown(0) && i == 6)
        {
            text.text = "This tree looks amazing!";
            i++;
        }
        else if (Input.GetMouseButtonDown(0) && i==7)
        {
            panel.SetActive(false);

            //PONER ESCENA A CARGAR DESPUES DE ESTE MINIJUEGO
            //SceneManager.LoadScene("");
            //Vale
            SceneManager.LoadScene("SesameStreet1");
        }
    }
}
