using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HairCustom : MonoBehaviour {


    public GameObject[] hairs;
    private int currentHair;


    void Update()
    {
        showCurrentHair();
    }



    public void showCurrentHair()
    {
        for (int i = 0; i < hairs.Length; i++)
        {
            if (i == currentHair)
            {
                hairs[i].SetActive(true);
            }
            else
            {
                hairs[i].SetActive(false);
            }
        }
    }

    public void SwitchHair()
    {
        if (currentHair == hairs.Length - 1)
        {
            currentHair = 0;
        }
        else
        {
            currentHair ++;
        }
    }

    

}
