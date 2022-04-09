using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Conversion : MonoBehaviour
{
    private string inputString;
    private double roundedCentimeters;
    private double preciseInches;
    private int preciseInchInt;
    [SerializeField] private Text input;
    [SerializeField] private Text output;
    [SerializeField] private GameObject inputObject;
    public void getInput()
    {
        inputString = input.text;
    }
    public void displayOutput()
    {
        getInput();
        if (isDouble(inputString))
        {
            output.text = (preciseInches*2.54).ToString();
        }
        else
        {
            output.text = "Invalid Input";
        }
        
    }
    public void quitApplication()
    {
        Application.Quit();
    }
    public void clear()
    {
        
        output.text = "~";
        
    }


    //input validation functions

    public bool isDouble(string text)
    {
        Debug.Log(text);
       if (double.TryParse(text,out preciseInches))
        {
            Debug.Log("True");
            return true;
        }
        Debug.Log("False");
        return false;
      
    }
   
}
