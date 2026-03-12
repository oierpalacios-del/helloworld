using UnityEngine;

public class tracker : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("X: " + transform.position.x + ", Y: " + transform.position.y + ", Z: " + transform.position.z);
        }
    }
}
