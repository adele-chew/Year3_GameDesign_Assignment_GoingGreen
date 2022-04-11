using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeImage : MonoBehaviour
{

    public GameObject[] instructionImage;       //Array of Image
    private int index;


    public void NextButton()
    {

        instructionImage[index].SetActive(false);       //hide current image
        index++;
        
        if(index > instructionImage.Length - 1)
        {
            index = 0;
        }

        instructionImage[index].SetActive(true);        //show next image
    }


    public void PreviousButton()
    {

        instructionImage[index].SetActive(false);       //hide current image

        index--;
        if (index < 0)
        {
            index = instructionImage.Length - 1;
        }

        instructionImage[index].SetActive(true);        //show previous image


    }
}