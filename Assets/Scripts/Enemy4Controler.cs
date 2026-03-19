using UnityEngine;
using System.Collections;
public class Enemy4Controler : MonoBehaviour
{
    public bool isShooting = false;

    public GameObject cube;
    public GameObject bullet2;
    public LineRenderer line;
    public GameObject bullet;
    float time = 0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        cube = GameObject.FindObjectOfType<PlayerEnemyHit>().gameObject;
        line.positionCount = 2;
        //line = GetComponent<LineRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        
        
        if (isShooting)
        {
            isShooting = false;
            StartCoroutine(WaitAndShoot());
        }
        else
        {
            time += Time.deltaTime;
            transform.LookAt(cube.transform);

            line.SetPosition(0, transform.position);
            line.SetPosition(1,cube.transform.position);
            if (time >= 5)
            {
                isShooting = true;
                time = 0;
            }

        }
    }

    private IEnumerator WaitAndShoot()
    {
        yield return new WaitForSeconds(0.5f);

        bullet = Instantiate(bullet2, transform.position, Quaternion.identity);
        bullet.transform.rotation = transform.rotation;
        

    }
}
