using UnityEngine;

public class  BallHit : MonoBehaviour
{

    public int brockHp;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        switch (brockHp)
        {
            case 1:
                GetComponent<MeshRenderer>().material.color = Color.green;
                break;
            case 2:
                GetComponent<MeshRenderer>().material.color = Color.blue;
                break;
            case 3 :
                GetComponent<MeshRenderer>().material.color = Color.red;
                break;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name.IndexOf("Ball") != -1)
        {
            brockHp -= 1;
            switch (brockHp)
            {
                case 1:
                    GetComponent<MeshRenderer>().material.color = Color.green;
                    break;
                case 2:
                    GetComponent<MeshRenderer>().material.color = Color.blue;
                    break;
                
            }
            
            if (brockHp <= 0)
            {
                FindObjectOfType<BrokenBrocksCount>().brokenBrocksCount++;
                Destroy(gameObject);
            }
            
        }
    }
}
