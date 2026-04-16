using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class PlayerManager : MonoBehaviour
{
    public float level = 1;
    public float takeDownCount = 0;
    public float attack = 1;
    public Image experience;
    public TextMeshProUGUI levelText;
    float a = 0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        levelText.text = level.ToString();
    }

    public void TakeDown()
    {
        takeDownCount++;
        ExperienceBar();
        if (takeDownCount == level)
        {
            level++;
            levelText.text = level.ToString();
            
            takeDownCount = 0;
            attack += 0.25f;
            GameObject.FindObjectOfType<Moviing>().speed += 2f;
            Debug.Log("Levelup");
        }
        
    }
    public void ExperienceBar()
    {
        experience.fillAmount = takeDownCount / level;
        if(experience.fillAmount == 1)
        {
            experience.fillAmount = 0;
        }
    }
    
}
