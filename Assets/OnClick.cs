using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnClick : MonoBehaviour
{
    // Start is called before the first frame update
    public static int Score = 0;


    void Start()
    {
        Score = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.touches.Length != 0)
        {
            int x = 0;
        }
        foreach (Touch touch in Input.touches)
        {
            if (touch.phase == TouchPhase.Began)
            {
                Score++;
            }
        }
    }
}
