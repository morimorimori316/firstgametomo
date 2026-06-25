using UnityEngine;
using System.Collections;

public class MoveBar : MonoBehaviour
{

    public float speed = 0.6f;
    private float time;
    private Rigidbody rb;
    private Coroutine c;
    public int atackPoint;

    private bool isEffectTime1 = false;

    private bool isEffectTime2 = false;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            rb.linearVelocity = new Vector3(speed*-1, 0, 0);
            
        }else if(Input.GetKey(KeyCode.D)){
            
            rb.linearVelocity = new Vector3(speed, 0, 0);
            
        }
        else
        {
            rb.linearVelocity = new Vector3(0, 0, 0);
        }
        

        

    }

    
    void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.name.IndexOf("item1") != -1)
        {
            Destroy(collision.gameObject);
            if (isEffectTime1 != true)
            {
                
                gameObject.transform.localScale = new Vector3(transform.localScale.x*2f,transform.localScale.y,transform.localScale.z) ;
                isEffectTime1 = true;
                c = StartCoroutine(EffectTime1());
                
            }
            else
            {
                StopCoroutine(c);
                c = null;
                c = StartCoroutine(EffectTime1());
                
            }

            
            
        }else if (collision.gameObject.name.IndexOf("item2") != -1)
        {
            Destroy(collision.gameObject);
            atackPoint++;
            StartCoroutine(EffectTime2());
        }
    }
    

    IEnumerator EffectTime1()
    {
        yield return new WaitForSeconds(30f);
        isEffectTime1 = false;
        gameObject.transform.localScale =
            new Vector3(transform.localScale.x / 2f, transform.localScale.y, transform.localScale.z);
    }

    IEnumerator EffectTime2()
    {
        yield return new WaitForSeconds(15f);
        atackPoint--;
    }
}
