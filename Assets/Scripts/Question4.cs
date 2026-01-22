using UnityEngine;
using UnityEngine.UI;
public class Question4 : MonoBehaviour
{
    public GameObject question;
    public float time = 0;

    public Image img;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        img = question.GetComponent<Image>();
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        if (time >= 1f)
        {
            img.fillAmount += 1 / 60f;
            time = 0;
        }
    }
}
