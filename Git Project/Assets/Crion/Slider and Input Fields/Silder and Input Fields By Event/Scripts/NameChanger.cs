using UnityEngine;
using TMPro;

public class NameChanger : MonoBehaviour
{
    public TMP_InputField inputField;
    public TextMeshProUGUI nameText;

    public void ChangeName()
    {
        nameText.text = inputField.text;
    }
}