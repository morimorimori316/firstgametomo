using UnityEngine;

public class BallHitBar : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public float ballHit = 1f;
    Rigidbody rb;
    Vector3 currentVelocity;
    float ballSpeed;
    Vector3 newDirection;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision collision)
    {
        rb = collision.gameObject.GetComponent<Rigidbody>();
        if(collision.gameObject.name.IndexOf("Ball") != -1)
        {
            //gameObject.GetComponent<Rigidbody>().AddForce(ballHit, 0f, 0f);
            currentVelocity = rb.linearVelocity;
            ballSpeed = currentVelocity.magnitude;
            newDirection = currentVelocity.normalized;
            newDirection.y = 1f;
            newDirection.x += ballHit;
            rb.linearVelocity = newDirection.normalized*ballSpeed;
        }
        
    }
}
