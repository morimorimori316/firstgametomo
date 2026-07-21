using UnityEngine;

public class BallHitBar2 : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    float ballHit = -1f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnCollisionEnter(Collision collision)
    {
        gameObject.GetComponent<Rigidbody>().AddForce(ballHit,0f,0f);
    }
}
