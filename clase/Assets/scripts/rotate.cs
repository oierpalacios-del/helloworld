using UnityEngine;

public class rotate : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.M))
        {
            gameObject.transform.rotation *= Quaternion.Euler(1, 0, 0);
        }
    }
}
