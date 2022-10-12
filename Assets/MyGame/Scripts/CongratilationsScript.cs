using UnityEngine;
using TMPro;

public class CongratilationsScript : MonoBehaviour
{
    public TextMeshProUGUI resultText;

    void Start()
    {
        resultText.text = PlayerPrefs.GetInt("PlayerResult").ToString();
    }
}
