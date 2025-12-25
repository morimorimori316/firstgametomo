using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    private Rigidbody rb;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.useGravity = !rb.useGravity;
        /*if (rb.useGravity )
        {
            rb.useGravity = true;
        }
        else
        {
            rb.useGravity = false;
        }

        if (rb.useGravity == false)
        {
            rb.useGravity = true;
        }
        else
        {
            rb.useGravity = false;
        }*/
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
