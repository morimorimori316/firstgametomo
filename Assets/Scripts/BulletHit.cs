using UnityEngine;

public class BulletHit : MonoBehaviour
{
    public int hp = 3;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name.IndexOf("Bullet") != -1)
        {
            hp -= 1;
            if (hp <= 0)
            {
                Destroy(gameObject);
            }
            
            
        }
    }
}
