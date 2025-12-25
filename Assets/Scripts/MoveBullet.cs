using UnityEngine;

public class MoveBullet : MonoBehaviour
{
    public float speed = 0.01f;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Destroy(gameObject, 3f);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(0, 0, 1f) * speed * Time.deltaTime;
    }
}
