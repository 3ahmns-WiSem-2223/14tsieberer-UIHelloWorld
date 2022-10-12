using UnityEngine;
using TMPro;


public class CalculationScript : MonoBehaviour
{
    public TextMeshProUGUI resultText;
    public int result;

    void Start()
    {
        result = 0;
        UpdateText();
    }

    public void Add()
    {
        result++;
        UpdateText();
    }

    public void Substract()
    {
        result--;
        UpdateText();
    }

    public void Divide()
    {
        result = result / 2;
        UpdateText();
    }

    public void Multiply()
    {
        result = result * 2;
        UpdateText();
    }

    void UpdateText()
    {
        PlayerPrefs.SetInt("PlayerResult", result);
        resultText.text = result.ToString();
    }
}
