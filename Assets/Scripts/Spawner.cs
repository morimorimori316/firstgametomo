using UnityEngine;
using System.Collections.Generic;

public class Spawner : MonoBehaviour
{
    public GameObject sphere;

    public List<GameObject> wave1 = new List<GameObject>();
    public List<GameObject> wave2 = new List<GameObject>();
    public List<GameObject> wave3 = new List<GameObject>();
    public bool isFighting = false;

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

            for (i = 0; i < wave1.Count; i++)
            {
                Instantiate(wave1[i], new Vector3(Random.Range(-5f, 5f), 0, 7f), Quaternion.identity);
                
            }
            isFighting = true;
        }
    }

}
