using UnityEngine;

public class MoveBall : MonoBehaviour
{
    public float speed = 5f;
    Vector3 currentVelocity;
    Vector3 newDirection;
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
    void FixedUpdate()
    {
        currentVelocity = myRigidbody.linearVelocity;
        newDirection = currentVelocity.normalized;
        myRigidbody.linearVelocity = newDirection * speed;
    }
}
