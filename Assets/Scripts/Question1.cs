using UnityEngine;

public class Question1 : MonoBehaviour
{
    public AudioSource audioSource;
    public GameObject cube;
    public GameObject cube2;
    private int a, b,c = 0;
    Color yellow = Color.yellow;
    public GameObject[] allCubes;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created                                   
    void Start()
    {

        allCubes = new GameObject[81];
        

        for (a = 0; a < 9; a++)
        {
            for (b = 0; b < 9; b++)
            {
                    
                cube2 = Instantiate(cube, new Vector3(a*2, 0, b*2), Quaternion.identity);
                allCubes[c] = cube2;
                cube2.GetComponent<MeshRenderer>().material.color = yellow;
                if (a >= 5)
                {
                    cube2.GetComponent<MeshRenderer>().material.color = Color.blue;
                }
                if (b >= 5)
                {
                    cube2.GetComponent<MeshRenderer>().material.color = Color.green;
                }
                if (a >= 5 && b >= 5)
                {
                    cube2.GetComponent<MeshRenderer>().material.color += Color.blue;
                }

                c++;
            }

            

        }
        
       
        
    }

    // Update is called once per frame
    void Update()
    {
        
        
    }

    public void AddGravity()
    {
        for (c = 0; c < 81; c++)
        {
            allCubes[c].GetComponent<Rigidbody>().useGravity = true;
        }
    }

    public void Audio()
    {
        audioSource.Play();
    }
}
