using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClothCustom : MonoBehaviour
{


    public GameObject[] cloth;
    private int currentCloth;


    void Update()
    {
        showCurrentCloth();
    }



    public void showCurrentCloth()
    {
        for (int i = 0; i < cloth.Length; i++)
        {
            if (i == currentCloth)
            {
                cloth[i].SetActive(true);
            }
            else
            {
                cloth[i].SetActive(false);
            }
        }
    }

    public void SwitchCloth()
    {
        if (currentCloth == cloth.Length - 1)
        {
            currentCloth = 0;
        }
        else
        {
            currentCloth ++;
        }
    }



}
