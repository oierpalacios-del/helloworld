using UnityEngine;

public class variavle : MonoBehaviour
{
    public int damage;
    private float velocity;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log(damage);
        damage = 10;
        velocity = 1.5f;
        Debug.Log(velocity);
        Debug.Log(damage);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
