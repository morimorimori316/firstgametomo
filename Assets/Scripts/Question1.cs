using UnityEngine;

public class Question1 : MonoBehaviour
{
    public GameObject cube;

    private int a, b;
    Color yellow = Color.yellow;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created                                   
    void Start()
    {


        

        for (a = 0; a < 9; a++)
        {
            for (b = 0; b < 9; b++)
            {
                    
                cube = Instantiate(cube, new Vector3(a*2, 0, b*2), Quaternion.identity);
                cube.GetComponent<MeshRenderer>().material.color = yellow;
                if (a >= 5)
                {
                    cube.GetComponent<MeshRenderer>().material.color = Color.blue;
                }
                if (b >= 5)
                {
                    cube.GetComponent<MeshRenderer>().material.color = Color.green;
                }
                if (a >= 5 && b >= 5)
                {
                    cube.GetComponent<MeshRenderer>().material.color += Color.blue;
                }
            }

            

        }
        
       
        
    }

    // Update is called once per frame
    void Update()
    {
        
        
    }
}
