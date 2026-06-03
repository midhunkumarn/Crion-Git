using UnityEngine;
using UnityEngine.EventSystems;
using TMPro;
//using UnityEngine.UI;

public class ButtonHoverIcon : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public TMP_Text buttonText;
    //public Button button;

    public void OnPointerEnter(PointerEventData eventData)
    {
        buttonText.gameObject.SetActive(false);
        //button.gameObject.SetActive(false);
       
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        buttonText.gameObject.SetActive(true);
        //button.gameObject.SetActive(true); 
       
    }
}