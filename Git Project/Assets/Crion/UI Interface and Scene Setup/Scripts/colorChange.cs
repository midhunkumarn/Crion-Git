using UnityEngine;

public class colorChange : MonoBehaviour
{
    private Renderer m_wallRenderer;

    void Start()
    {
        m_wallRenderer = GetComponent<Renderer>();
    }

    void OnMouseDown()
    {
        Color randomColor = new Color(
            Random.value,
            Random.value, 
            Random.value  
        );

        m_wallRenderer.material.color = randomColor;
    }
}
