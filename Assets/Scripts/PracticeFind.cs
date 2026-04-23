using UnityEngine;

public class PracticeFind : MonoBehaviour
{
    public GameObject cube;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //GameObject cube = GameObject.FindWithTag("Player");
        //Debug.Log(cube.name);
        //Debug.Log(GameObject.Find("Player").name);

        transform.position = GameObject.Find("Cube").transform.position;
    }
    

    // Update is called once per frame
    void Update()
    {
        
    }
}
