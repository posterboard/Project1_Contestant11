using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Conversion : MonoBehaviour
{
    private string inputString;
    private double preciseInches;
    [SerializeField] private Text input;
    [SerializeField] private Text output;
    [SerializeField] private InputField inputObject;
    public void getInput()
    {
        inputString = input.text;
    }
    //attached to calculate button-gets value of textfield in input field, converts and rounds to nearest Integer, and displays it.
    public void displayOutput()
    {
        getInput();
        if (isDouble(inputString))
        {
            output.text = (preciseInches * 2.54).ToString("F0");
        }
        else
        {
            output.text = "Invalid Input";
        }

    }
    //attached to exit button
    public void quitApplication()
    {
        Application.Quit();
    }
    public void clear()
    {

        inputObject.text = "";
        output.text = "~";

    }


    //input validation functions

    public bool isDouble(string text)
    {

        if (double.TryParse(text, out preciseInches))
        {

            return true;
        }

        return false;

    }

}
