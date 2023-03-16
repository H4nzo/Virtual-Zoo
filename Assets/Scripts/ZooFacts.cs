using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ZooFacts : MonoBehaviour
{
    public GameObject[] animals;

    private void OnTriggerStay(Collider other)
    {
        switch (other.tag)
        {
            case "Eagle":
                //Display Eagle Facts
                animals[0].SetActive(true);

                break;
            case "Elephant":
                //Display Elephant Facts
                animals[1].SetActive(true);

                break;
            case "Zebra":
                //Display Zebra Facts over Text UI
                 animals[2].SetActive(true);

                break;
            case "Fox":
                //Display Fox Facts
                 animals[3].SetActive(true);

                break;
            case "Wolf":
                //Display Wolf Facts
                 animals[4].SetActive(true);

                break;
            case "Lion":
                //Display Lion Facts
                 animals[5].SetActive(true);

                break;
            case "Bear":
                //Display Bear Facts 
                 animals[6].SetActive(true);

                break;
            case "Stag":
                //Display Stag Facts
                 animals[7].SetActive(true);

                break;
            case "Rhino":
                //Display Rhinoceros Facts
                 animals[8].SetActive(true);

                break;
        }
    }

      private void OnTriggerExit(Collider other)
    {
        switch (other.tag)
        {
            case "Eagle":
               
                animals[0].SetActive(!true);

                break;
            case "Elephant":
               
                animals[1].SetActive(!true);

                break;
            case "Zebra":
                
                 animals[2].SetActive(!true);

                break;
            case "Fox":
                
                 animals[3].SetActive(!true);

                break;
            case "Wolf":
                
                 animals[4].SetActive(!true);

                break;
            case "Lion":
               
                 animals[5].SetActive(!true);

                break;
            case "Bear":
                
                 animals[6].SetActive(!true);

                break;
            case "Stag":
                
                 animals[7].SetActive(!true);

                break;
            case "Rhino":
                
                 animals[8].SetActive(!true);

                break;
        }
    }



}
