using UnityEditor;
using UnityEngine;

public class SampleLine : MonoBehaviour
{
    private LineRenderer line;
    private int a=0;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        line = GetComponent<LineRenderer>();

        /*line.positionCount = 2; // 点の数

        line.SetPosition(0, new Vector3(0, 0, 0));
        line.SetPosition(1, new Vector3(5, 0, 0));
        line.startWidth = 0.2f;
        line.endWidth = line.startWidth;
        line.startColor = Color.green;
        line.endColor = line.startColor;*/
        
        
        /*line.positionCount = 4;
        line.SetPosition(0,new Vector3(0,0,0));
        line.SetPosition(1,new Vector3(1,Mathf.Sqrt(3),0));
        line.SetPosition(2,new Vector3(2,0,0));
        line.SetPosition(0,new Vector3(0,0,0));*/
        
        


    }

    // Update is called once per frame
    void Update()
    {
        /*if (Input.GetMouseButtonDown(0))
        {
            line.positionCount = a+1;
            
            Vector3 mousePos = Input.mousePosition;
            mousePos.z = 10f;
            Vector3 worldPos = Camera.main.ScreenToWorldPoint(mousePos);
            line.SetPosition(a,worldPos);
            a++;
        }*/
        if (Input.GetMouseButton(0))
        {
            line.positionCount = a+1;
            
            Vector3 mousePos = Input.mousePosition;
            mousePos.z = 10f;
            Vector3 worldPos = Camera.main.ScreenToWorldPoint(mousePos);
            line.SetPosition(a,worldPos);
            a++;
        }
        
        
    }
}
