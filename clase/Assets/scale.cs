using UnityEngine;

public class scale : MonoBehaviour
{
    [SerializeField] private float scaleSpeed = 4f;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Q))
        {
            transform.localScale = transform.localScale + new Vector3(1, 1, 1) * scaleSpeed * Time.deltaTime;
        }
        else if (Input.GetKey(KeyCode.E))
        {
            transform.localScale = transform.localScale - new Vector3(1, 1, 1) * scaleSpeed * Time.deltaTime;
        }
    }
}
