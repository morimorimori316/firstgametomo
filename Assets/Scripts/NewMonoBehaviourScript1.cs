using UnityEngine;
using TMPro;
public class NewMonoBehaviourScript1 : MonoBehaviour
{
    private TextMeshProUGUI textPro;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public void ChangeText()
    {
        textPro = GetComponent<TextMeshProUGUI>();
        textPro.text = "test";
 
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
