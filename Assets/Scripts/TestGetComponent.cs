using UnityEngine;

public class TestGetComponent : MonoBehaviour
{
    private Rigidbody rb;
    private MeshRenderer ma;
    private float a=0;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        ma = GetComponent<MeshRenderer>();
        /*rb.useGravity = false;*/
    }
    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < 0)
        {
            rb.AddForce(Vector3.up * 10f);
        }

        ma.material = null;
        a += Time.deltaTime;
        if (a >= 3)
        {
            //ma.enabled = false;
            gameObject.SetActive(false);
        }
    }
}
