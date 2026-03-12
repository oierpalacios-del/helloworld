using UnityEngine;

public class movimiento : MonoBehaviour
{
    [SerializeField] private CharacterController controller;
    [SerializeField] private float speed = 10f;
    [SerializeField] private float gravity = 9.8f;
    [SerializeField] private float threshold = 30f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
       controller = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.position = transform.position + (Vector3.forward * speed * Time.deltaTime);
        }
        else if (Input.GetKey(KeyCode.S))
        {
            transform.position = transform.position - (Vector3.forward * speed * Time.deltaTime);
        }
        else if (Input.GetKey(KeyCode.D))
        {
            transform.position = transform.position - (Vector3.left * speed * Time.deltaTime);
        }
        else if (Input.GetKey(KeyCode.A))
        {
            transform.position = transform.position + (Vector3.left * speed * Time.deltaTime);
        }
        else if (Input.GetKey(KeyCode.Space))
        {
            transform.position = transform.position + (Vector3.up * gravity * Time.deltaTime);
        }
        else if (Input.GetKey(KeyCode.LeftShift))
        {
            transform.position = transform.position - (Vector3.up * gravity * Time.deltaTime);
        }
    }
}
