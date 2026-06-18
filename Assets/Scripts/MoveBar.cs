using UnityEngine;

public class MoveBar : MonoBehaviour
{

    public float speed = 0.6f;
    private float time;
    private Rigidbody rb;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            rb.linearVelocity = new Vector3(speed*-1, 0, 0);
            
        }else if(Input.GetKey(KeyCode.D)){
            
            rb.linearVelocity = new Vector3(speed, 0, 0);
            
        }
        else
        {
            rb.linearVelocity = new Vector3(0, 0, 0);
        }
        

        

    }

    
    void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.name.IndexOf("item") != -1)
        {
            Destroy(collision.gameObject);
        }
    }
}
