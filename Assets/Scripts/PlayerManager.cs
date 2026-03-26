using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    public int level = 1;
    public int takeDownCount = 0;
    public float attack = 1;
   
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    public void TakeDown()
    {
        takeDownCount++;
        if (takeDownCount == level)
        {
            level++;
            takeDownCount = 0;
            attack += 0.25f;
            GameObject.FindObjectOfType<Moviing>().speed += 2f;
            Debug.Log("Levelup");
        }
        
    }
    
}
