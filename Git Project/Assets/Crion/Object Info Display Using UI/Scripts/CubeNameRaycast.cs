using UnityEngine;
using TMPro;
using UnityEngine.EventSystems;

public class CubeNameRaycast : MonoBehaviour
{
    [Header("UI References")]
    public TMP_Text objectNameText;
    public TMP_InputField nameInputField;
    public GameObject infoPanel;

    private Renderer currentRenderer;
    private Color originalColor;
    private GameObject selectedObject;

    void Start()
    {
        infoPanel.SetActive(false);
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
           
            if (EventSystem.current != null &&
                EventSystem.current.IsPointerOverGameObject())
            {
                return;
            }

            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit))
            {
                Renderer hitRenderer = hit.collider.GetComponent<Renderer>();

                if (hitRenderer != null)
                {
                  
                    if (currentRenderer != null && currentRenderer != hitRenderer)
                    {
                        currentRenderer.material.color = originalColor;
                    }

                    
                    if (currentRenderer != hitRenderer)
                    {
                        originalColor = hitRenderer.material.color;

                        selectedObject = hit.collider.gameObject;

                        objectNameText.text = "Selected: " + selectedObject.name;
                        nameInputField.text = selectedObject.name;

                        infoPanel.SetActive(true);
                    }

                    
                    hitRenderer.material.color = Color.red;

                    currentRenderer = hitRenderer;
                }
            }
            else
            {
               
                infoPanel.SetActive(false);

                if (currentRenderer != null)
                {
                    currentRenderer.material.color = originalColor;
                    currentRenderer = null;
                    selectedObject = null;
                }
            }
        }
    }

    public void RenameSelectedObject()
    {
        if (selectedObject != null)
        {
            string newName = nameInputField.text.Trim();

            if (!string.IsNullOrEmpty(newName))
            {
                selectedObject.name = newName;
                objectNameText.text = "Selected: " + selectedObject.name;
            }
        }
    }
}