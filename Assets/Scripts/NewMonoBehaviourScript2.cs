using UnityEngine;
using UnityEngine.UI;
public class NewMonoBehaviourScript2 : MonoBehaviour
{
    public PlayerEnemyHit pe;

    private Image hpBar;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        hpBar = GetComponent<Image>();
    }

    // Update is called once per frame
    void Update()
    {
        hpBar.fillAmount = (float)pe.hp / 3f;
    }
}
