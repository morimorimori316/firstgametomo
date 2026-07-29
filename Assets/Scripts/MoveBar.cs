using UnityEngine;
using System.Collections;

public class MoveBar : MonoBehaviour
{

    public float speed = 0.6f;
    private float time;
    private Rigidbody rb;
    private Coroutine c1,c2;
    public int atackPoint;
    public GameObject ball3;
    public GameObject ball;
    private bool isEffectTime1 = false;
    private int i;
    public int ballCount = 1;
    private GameObject ball2;
    private float ballSpeed = 5f;
    GameObject[] addBall;
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
                c1 = StartCoroutine(EffectTime1());
                
            }
            else
            {
                StopCoroutine(c1);
                c1 = null;
                c1 = StartCoroutine(EffectTime1());
                
            }

            
            
        }else if (collision.gameObject.name.IndexOf("item2") != -1)
        {
            if(isEffectTime2!= true)
            {
                Destroy(collision.gameObject);
                atackPoint++;
                c2 = StartCoroutine(EffectTime2());
            }
            else
            {
                StopCoroutine(c2);
                c2 = null;
                c2 = StartCoroutine(EffectTime2());
            }
            
            
        }else if (collision.gameObject.name.IndexOf("item3") != -1)
        {
            Destroy(collision.gameObject);

            addBall = GameObject.FindGameObjectsWithTag("ball");
            
            ball2 =  Instantiate(ball3, addBall[0].transform.position, Quaternion.identity);
            //ball2.GetComponent<Rigidbody>().linearVelocity = new Vector3(ballSpeed, ballSpeed, 0f);
            ball2.GetComponent<Rigidbody>().AddForce(new Vector3(speed,speed,0f));
            ball2 = Instantiate(ball3, addBall[0].transform.position, Quaternion.identity);
            //ball2.GetComponent<Rigidbody>().linearVelocity = new Vector3(-ballSpeed, -ballSpeed, 0f);
            ball2.GetComponent<Rigidbody>().AddForce(new Vector3(-speed,speed,0f));
            ballCount += 2;
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
