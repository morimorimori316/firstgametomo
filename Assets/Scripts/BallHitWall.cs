using UnityEngine;

public class BallHitWall : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    GameObject ball;
    public bool isHittingWall = false;
    public int hitWallCount = 0;
    Vector3 currentVelocity;
    float ballSpeed;
    Vector3 newDirection;
    Rigidbody rb;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.name.IndexOf("RightWall") != -1)
        {
            if (isHittingWall)
            {
                hitWallCount++;
            }
            isHittingWall = true;
        }
        if (collision.gameObject.name.IndexOf("LeftWall") != -1)
        {
            if (isHittingWall)
            {
                hitWallCount++;
            }
            isHittingWall = true;
        }
        if(collision.gameObject.name.IndexOf("Bar") != -1)
        {
            isHittingWall = false;
            hitWallCount = 0;
        }

        if(hitWallCount >= 20)
        {
            rb = GetComponent<Rigidbody>();
            currentVelocity = rb.linearVelocity;
            ballSpeed = currentVelocity.magnitude;
            newDirection = currentVelocity.normalized;
            newDirection.y = -1f;
            rb.linearVelocity = newDirection.normalized * ballSpeed;
            Debug.Log("aaaaaaaabbaaaaaaaa");
        }

    }
}

