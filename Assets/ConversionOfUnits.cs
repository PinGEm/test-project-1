using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ConversionOfUnits : MonoBehaviour
{
    public float PHP;
    public float convertedValue;
    public float Euro;
    public float Yen;
    public float Won;
    public float BTC;

    public TMP_InputField InputField;
    public TextMeshProUGUI convertedText;

    public void ToPeso()
    {
        string inputValue = InputField.text;
        float numericValue;
        if (float.TryParse(inputValue, out numericValue))
        {
            Debug.Log(numericValue);
            // Convert to PHP
            convertedValue = numericValue * PHP;
            convertedText.text = "Converted value: ₱" + convertedValue.ToString();

        }
        else
        {
            InputField.text = "Please input a number.";
        }
    }

    public void ToBTC()
    {
        string inputValue = InputField.text;
        float numericValue;
        if (float.TryParse(inputValue, out numericValue))
        {
            Debug.Log(numericValue);
            // Convert to BTC
            convertedValue = numericValue * BTC;
            convertedText.text = "Converted value: BTC" + convertedValue.ToString();

        }
        else
        {
            InputField.text = "Please input a number.";
        }
    }

    public void ToEuro()
    {
        string inputValue = InputField.text;
        float numericValue;
        if (float.TryParse(inputValue, out numericValue))
        {
            Debug.Log(numericValue);
            // Convert to BTC
            convertedValue = numericValue * Euro;
            convertedText.text = "Converted value: €" + convertedValue.ToString();

        }
        else
        {
            InputField.text = "Please input a number.";
        }
    }

    public void ToWon()
    {
        string inputValue = InputField.text;
        float numericValue;
        if (float.TryParse(inputValue, out numericValue))
        {
            Debug.Log(numericValue);
            // Convert to BTC
            convertedValue = numericValue * Won;
            convertedText.text = "Converted value: ₩" + convertedValue.ToString();

        }
        else
        {
            InputField.text = "Please input a number.";
        }
    }

    public void ToYen()
    {
        string inputValue = InputField.text;
        float numericValue;
        if (float.TryParse(inputValue, out numericValue))
        {
            Debug.Log(numericValue);
            // Convert to BTC
            convertedValue = numericValue * Yen;
            convertedText.text = "Converted value: ¥" + convertedValue.ToString();

        }
        else
        {
            InputField.text = "Please input a number.";
        }
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
