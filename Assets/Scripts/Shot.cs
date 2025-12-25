using UnityEngine;

public class Shot : MonoBehaviour
{
    public GameObject bullet;
    private AudioSource au;
    private GameObject bullet1;

    public AudioClip clickSound;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        au = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            bullet1 = Instantiate(bullet, transform.position, Quaternion.identity);
            bullet1.transform.localEulerAngles = new Vector3(90f,0, 0);
            au.PlayOneShot(clickSound);
        }
    }
}
