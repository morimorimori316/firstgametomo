using UnityEngine;

public class Question1 : MonoBehaviour
{
    public GameObject cube;

    private int a, b;

    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        for (a = 0; a < 9; a++)
        {
            for (b = 0; b < 9; b++)
            {
                    
                Instantiate(cube, new Vector3(a*2, 0, b*2), Quaternion.identity);
                   
                    
            }

            

        }
    }

    // Update is called once per frame
    void Update()
    {
        
        
    }
}
