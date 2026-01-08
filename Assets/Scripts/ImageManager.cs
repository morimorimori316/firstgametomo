using UnityEngine;
using UnityEngine.UI;

public class ImageManager : MonoBehaviour
{
    public GameObject horizonImage;
    public Image ing;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        ing = horizonImage.GetComponent<Image>();
        //ing.fillAmount = 0.5f;

    }

    // Update is called once per frame
    void Update()
    {
        ing.fillAmount -= 0.01f * Time.deltaTime;
    }
    
    
}

