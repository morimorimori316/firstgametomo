using UnityEngine;
using TMPro;
public class BrokenBrocksCount : MonoBehaviour
{
    public TextMeshProUGUI brokenBrocksCountText;
    public int brokenBrocksCount = 0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (brokenBrocksCount == 20)
        {
            brokenBrocksCountText.text = "clear";
        }
    }
}
