using UnityEngine;

public class ChasePlayer : MonoBehaviour
{
    private Transform playerTransform;

    public float speed1;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        playerTransform = GameObject.FindObjectOfType<Moviing>().transform;

    }

    // Update is called once per frame
    void Update()
    {
    transform.LookAt(playerTransform);
    transform.position += transform.forward * speed1 * Time.deltaTime;
    }
}
