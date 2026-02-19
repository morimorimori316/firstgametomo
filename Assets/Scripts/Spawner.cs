using UnityEngine;
using System.Collections.Generic;
using UnityEngine.InputSystem.Switch;

public class Spawner : MonoBehaviour
{
    public GameObject sphere;
    public int takeDownCount = 0;
    public List<GameObject> wave1 = new List<GameObject>();
    public List<GameObject> wave2 = new List<GameObject>();
    public List<GameObject> wave3 = new List<GameObject>();
    public bool isFighting = false;
    private int a=0;
    private float c = 0;
    public float puttingTime = 3f;
    
    private int i;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        /*c += Time.deltaTime;
        if (c >= 3f)
        {
            Instantiate(sphere, new Vector3(Random.Range(-5f, 5f), 0, 7f), Quaternion.identity);
            c = 0f;
        }*/
        if (isFighting)
        {

            switch (a)
            {
                case 1:
                    if (takeDownCount == wave1.Count)
                    {
                        isFighting = false;
                        takeDownCount = 0;
                    } 
                    
                    break;
                case 2:
                    if (takeDownCount == wave2.Count)
                    {
                        isFighting = false;
                        takeDownCount = 0;
                    }

                    break;
                case 3:
                    if (takeDownCount == wave3.Count)
                    {
                        isFighting = false;
                        takeDownCount = 0;
                    }

                    break;
                
            }
        }
        else
        {
            PuttingEnemy();
        }
    }

    void PuttingEnemy()
    {
        c += Time.deltaTime;
        if (c >= puttingTime)
        {

            a++;
            switch (a)
            {
                case 1:
                    for (i = 0; i < wave1.Count; i++)
                    {
                        Instantiate(wave1[i], new Vector3(Random.Range(-5f, 5f), 0, 7f), Quaternion.identity);
                
                    }

                    break;
                case 2 :
                    for (i = 0; i < wave2.Count; i++)
                    {
                        Instantiate(wave2[i], new Vector3(Random.Range(-5f, 5f), 0, 7f), Quaternion.identity);
                
                    }

                    break;
                case 3:
                    for (i = 0; i < wave3.Count; i++)
                    {
                        Instantiate(wave3[i], new Vector3(Random.Range(-5f, 5f), 0, 7f), Quaternion.identity);
                
                    }

                    break;
            }
            
            isFighting = true;
            c = 0;
            
        }
    }

}
