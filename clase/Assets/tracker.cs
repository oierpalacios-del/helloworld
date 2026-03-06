using UnityEngine;

public class tracker : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("X: " + transform.position.x + ", Y: " + transform.position.y + ", Z: " + transform.position.z);
        }
    }
}
