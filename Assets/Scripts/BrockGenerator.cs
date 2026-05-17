using UnityEngine;

public class BrockGenerator : MonoBehaviour
{
    int j,i;
    public GameObject Brock;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        for(i = 0; i<=5; i++)
        {
            for(j = -2; j <= 2; j++)
            {
                Instantiate(Brock, new Vector3(j*2, i+1, 0),Quaternion.identity);
                
            }
        }
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
