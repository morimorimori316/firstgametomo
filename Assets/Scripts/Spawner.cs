using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject sphere;

    private float c = 0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        c += Time.deltaTime;
        if (c >= 3f)
        {
            Instantiate(sphere, new Vector3(Random.Range(-5f, 5f), 0, 7f), Quaternion.identity);
            c = 0f;
        }
    }
}
