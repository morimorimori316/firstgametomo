using UnityEngine;

public class MoviingLifeTime : MonoBehaviour
{
    public float a;

    private Moviing moviing;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        moviing = GetComponent<Moviing>();
    }

    // Update is called once per frame
    void Update()
    {
        a += Time.deltaTime;
        if (a >= 5)
        {
            //moviing.speed = 0;
            moviing.enabled = false;
        }
    }
}
