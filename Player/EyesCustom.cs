using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EyesCustom : MonoBehaviour
{


    public GameObject[] eyes;
    private int currentEyes;


    void Update()
    {
        showCurrentEyes();
    }



    public void showCurrentEyes()
    {
        for (int i = 0; i < eyes.Length; i++)
        {
            if (i == currentEyes)
            {
                eyes[i].SetActive(true);
            }
            else
            {
                eyes[i].SetActive(false);
            }
        }
    }

    public void SwitchEyes()
    {
        if (currentEyes == eyes.Length - 1)
        {
            currentEyes = 0;
        }
        else
        {
            currentEyes ++;
        }
    }



}
