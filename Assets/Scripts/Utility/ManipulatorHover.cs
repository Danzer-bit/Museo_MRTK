using UnityEngine;

public class ManipulatorHover : MonoBehaviour
{
    private Renderer objectRenderer;
    private Color originalColor;
    public Color hoverColor = Color.yellow;
    
    void Start()
    {
        objectRenderer = GetComponent<Renderer>();
        originalColor = objectRenderer.material.color;
    }
    
    public void OnHoverStart()
    {
        objectRenderer.material.color = hoverColor;
    }
    
    public void OnHoverEnd()
    {
        objectRenderer.material.color = originalColor;
    }
}