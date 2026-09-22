using UnityEngine;

public class Test2 : MonoBehaviour
{
    private float a = 0;
    public GameObject cube;
    private float b = 1f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        a += Time.deltaTime;
        
        if (a >= b)
        {
            cube.transform.localScale = new Vector3(b, b, b);
            b += 1f;
        }
    }
}
