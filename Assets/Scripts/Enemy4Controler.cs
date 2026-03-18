using UnityEngine;

public class Enemy4Controler : MonoBehaviour
{
    public bool isShooting = false;

    public GameObject cube;
    public LineRenderer line;
    float time = 0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        line.positionCount = 2;
        //line = GetComponent<LineRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        
        
        if (isShooting)
        {
            
        }
        else
        {
            time += Time.deltaTime;
            transform.LookAt(cube.transform);

            line.SetPosition(0, transform.position);
            line.SetPosition(1,cube.transform.position);
            if (time >= 5)
            {
                isShooting = true;
                time = 0;
            }

        }
    }
}
