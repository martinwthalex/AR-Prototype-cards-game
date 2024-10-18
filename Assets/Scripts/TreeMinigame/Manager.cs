using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager : MonoBehaviour
{
    public GameObject wateringCan;
    public GameObject cloud;
    public static int MAX_WateringCans = 1;
    public static int currentWateringCans;
    public GameObject texts;
    public static int MAX_Clouds = 1;
    public static int currentClickedClouds = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void ClickWateringCan()
    {
        currentWateringCans++;
        wateringCan.SetActive(false);
    }
    public void ClickClouds()
    {
        currentClickedClouds++;
        cloud.SetActive(false);
    }
}
