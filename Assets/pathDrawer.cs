
using UnityEngine;

public class PathDrawer : MonoBehaviour
{
    public Transform pointA; // Canvas
    public Transform pointB; // Stanza
    private LineRenderer line;

    void Start()
    {
        line = GetComponent<LineRenderer>();
        line.positionCount = 2;
        line.startWidth = 0.02f;
        line.endWidth = 0.02f;
        line.material = new Material(Shader.Find("Sprites/Default"));
        line.startColor = Color.cyan;
        line.endColor = Color.cyan;

        line.SetPosition(0, pointA.position);
        line.SetPosition(1, pointB.position);
    }
}