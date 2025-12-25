using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerEnemyHit : MonoBehaviour
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
        if (collision.gameObject.name.IndexOf("Sphere") != -1)
        {
            
            hp -= 1;
            Destroy(collision.gameObject);
            if (hp <= 0)
            {
                Debug.Log("Game Over!");
                SceneManager.LoadScene("GameOver");
            }
        }
            
        
    }
}
