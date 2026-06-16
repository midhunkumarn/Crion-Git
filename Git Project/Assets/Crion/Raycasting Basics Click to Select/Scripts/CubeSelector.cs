using UnityEngine;

public class CubeSelector : MonoBehaviour
{
    private Renderer currentRenderer;
    private Color originalColor;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
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
                    }
             
                    hitRenderer.material.color = Color.red;

                    currentRenderer = hitRenderer;
                }
            }
        }
    }
}