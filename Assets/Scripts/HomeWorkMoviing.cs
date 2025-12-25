using UnityEngine;

public class HomeWorkMoviing : MonoBehaviour
{
    public float speed = 1f;
    public bool a = false;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.position += new Vector3(0, 0, 1f) * speed * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.S))
        {
            transform.position -= new Vector3(0, 0, 1f) * speed * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.D))
        {
            transform.position += new Vector3(1f, 0, 0) * speed * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.A))
        {
            transform.position -= new Vector3(1f, 0, 0) * speed * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.Space) && !a)
        {
            //transform.localScale = new Vector3(2f, 2f, 2f);
            transform.localScale *= 2f;
            a = true;

        }


    }
}