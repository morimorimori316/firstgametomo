using UnityEngine;

public class MoveBall : MonoBehaviour
{
    public float speed = 5f;

    private Rigidbody myRigidbody;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        myRigidbody = GetComponent <Rigidbody>();
        myRigidbody.linearVelocity = new Vector3(speed, speed, 0f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
