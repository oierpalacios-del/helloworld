using UnityEngine;

public class hello : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log("Hello: " + gameObject.name);
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Hello: " + gameObject.name);
        Debug.Log("Posicion: " + transform.position.ToString());
    }
}
