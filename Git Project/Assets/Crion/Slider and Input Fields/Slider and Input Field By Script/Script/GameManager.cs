using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameManager : MonoBehaviour
{
    public GameObject sidePanel;

    public Slider sizeSlider;
    public TMP_InputField inputField;
    public Button changeButton;

    public TMP_Text nameText;
    public Transform cube;

    private void Start()
    {
        
        sidePanel.SetActive(true);
        sizeSlider.onValueChanged.AddListener(ChangeCubeSize);
        changeButton.onClick.AddListener(ChangeCubeName);
    }

    private void ChangeCubeSize(float value)
    {
        cube.localScale = Vector3.one * value;
    }

    private void ChangeCubeName()
    {
        if (!string.IsNullOrWhiteSpace(inputField.text))
        {
            nameText.text = inputField.text;
        }
    }
}