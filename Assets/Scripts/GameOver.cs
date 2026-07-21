using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour

{
    public int  downBallCount = 0;
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
        if (collision.gameObject.name.IndexOf("Ball") != -1)
        {
            Destroy(collision.gameObject);
            downBallCount++;
            Debug.Log(downBallCount);
            if (downBallCount == FindObjectOfType<MoveBar>().ballCount)
            {
                SceneManager.LoadScene("GameOver");
            }
            
        }
    }
}
