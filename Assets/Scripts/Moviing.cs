using UnityEngine;

public class Moviing : MonoBehaviour
{
    public float speed = 0.5f;
    private float a = 0f;

    private float b = 0f;
    public GameObject sphere;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        /*
        if (Input.GetKey(KeyCode.W))
        {
            transform.position += new Vector3(0, 0, 0.1f) * speed * Time.deltaTime;
        }    
        
        if (Input.GetKey(KeyCode.A))
        {
            transform.position += new Vector3(-0.1f, 0, 0) * speed * Time.deltaTime;
        } 
        
        if (Input.GetKey(KeyCode.D))
        {
            transform.position += new Vector3(0.1f, 0, 0) * speed * Time.deltaTime;
        } 
        
        if (Input.GetKey(KeyCode.S))
        {
            transform.position += new Vector3(0, 0, -0.1f) * speed * Time.deltaTime;
        } 
        */
        if (Input.GetKey(KeyCode.W))
        {
            transform.position += transform.forward * speed * Time.deltaTime;
        }    
        
        if (Input.GetKey(KeyCode.A))
        {
            transform.position -= transform.right * speed * Time.deltaTime;
        } 
        
        if (Input.GetKey(KeyCode.D))
        {
            transform.position += transform.right * speed * Time.deltaTime;
        } 
        
        if (Input.GetKey(KeyCode.S))
        {
            transform.position -= transform.forward * speed * Time.deltaTime;
        }

        /*if (Input.GetKey(KeyCode.Space))
        {
            transform.position = new Vector3(1, 2, 3);
        }*/

        a += Time.deltaTime;
        //Debug.Log(Time.time);
        /*if (Vector3.Distance(transform.position, sphere.transform.position) <= 1f)
        {
            Debug.Log("near");
        }*/

    }
}
