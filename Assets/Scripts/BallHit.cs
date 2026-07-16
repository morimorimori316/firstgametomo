using UnityEngine;
using System.Collections.Generic;
public class  BallHit : MonoBehaviour
{

    public int brockHp;
    private bool isRed;
    private int randomItem;
    public List<GameObject> items = new List<GameObject>();
    public int atackPoint = 0;

    
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

        if (brockHp == 3)
        {
            isRed = true;
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
            atackPoint = FindObjectOfType<MoveBar>().atackPoint;
            brockHp -= 1 + atackPoint;
            
            
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

                if (isRed)
                {
                    randomItem = Random.Range(0, items.Count);
                    Instantiate(items[2], transform.position, Quaternion.identity);
                }
                Destroy(gameObject);
            }
            
        }
    }
}
