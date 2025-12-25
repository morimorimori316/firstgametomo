using UnityEngine;

public class Test : MonoBehaviour
{
    public GameObject sphere;
    private GameObject instanceSphere;

    private float a = 0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
       instanceSphere = Instantiate(sphere, new Vector3(0, 0, 0),Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        a += Time.deltaTime;

        if (a >= 5f&& Vector3.Distance(instanceSphere.transform.position, transform.position)<=2)
        {
            transform.position = new Vector3(0, 1, 0);
            instanceSphere.transform.position = new Vector3(0, 1, 0);
        }
            
    }
}
