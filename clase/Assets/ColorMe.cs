using UnityEngine;

public class ColorMe : MonoBehaviour
{
    public Color color = Color.blue;
    [SerializeField] private MeshRenderer renderer;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        renderer = GetComponent<MeshRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        renderer.material.color = color;
    }
}
