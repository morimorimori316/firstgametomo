using UnityEngine;

public class BrockGenerator : MonoBehaviour
{
    int j,i;
    public GameObject brock;

    public GameObject brock2;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        for(i = 0; i<5; i++)
        {
            for(j = -2; j < 2; j++)
            {
                brock2 = Instantiate(brock, new Vector3(j*2, i+1, 0),Quaternion.identity);
                switch (i)
                {
                    case 0:
                        FindObjectOfType<BallHit>().brockHp = 1;
                        break;
                    case 1:
                        FindObjectOfType<BallHit>().brockHp = 2;
                        break; 
                        
                    case 2:
                        FindObjectOfType<BallHit>().brockHp = 3;
                        brock2.name = "red";
                        break;
                }
            }
        }
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
