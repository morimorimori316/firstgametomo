using UnityEngine;
using System.Collections.Generic;

public class practiceList : MonoBehaviour
{
    private List<string> list = new List<string>();
    private List<int> score = new List<int>();
    private int a,i;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        list.Add("ramenn");
        list.Add("chocolate");
        list.Add("rice");
        list.Add("banana");
        a = list.Count;
        for (i = 0; i < a; i++)
        {
            Debug.Log(list[i]);
        }
        
        score.Add(82);
        score.Add(-82);
        score.Add(23);
        score.Add(17);
        score.Sort();
        a = score.Count;
        for (i = 0; i < a; i++)
        {
            Debug.Log(score[i]);
        }
        Debug.Log(score[a-1]);

        list.Remove("rice");
        a = list.Count;
        Debug.Log(a);
        Debug.Log($"{a}");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    
}
