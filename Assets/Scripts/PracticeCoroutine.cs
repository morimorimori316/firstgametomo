using System.Collections;
using UnityEngine;
using System.Collections;
public class PracticeCoroutine : MonoBehaviour
{
    private int a;

    private float b = 0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //StartCoroutine(Hello());
        //StartCoroutine(Number());
        //StartCoroutine(Move());
        Destroy(gameObject, 3f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator Hello()
    {
        yield return new WaitForSeconds(2f);
        Debug.Log("Hello");
    }

    IEnumerator Number()
    {
        for (a = 1; a < 6; a++)
        {
            yield return new WaitForSeconds(1f);
            Debug.Log(a);
        }
    }

    IEnumerator Move()
    {
        while (true)
        {
            b += Time.deltaTime;
            if (b >= 5f)
            {
                break;
            }
            yield return null;
            transform.position += new Vector3(0.05f, 0f, 0f);


        }
    }
}
