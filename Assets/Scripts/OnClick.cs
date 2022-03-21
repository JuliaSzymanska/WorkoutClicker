using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using Input = Wrappers.Input;

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
        #if (UNITY_IPHONE || UNITY_ANDROID)
        foreach (Touch touch in Input.touches)
        {
            if (touch.phase == TouchPhase.Began)
            {
                Score++;
            }
        }
        #endif



    }


}
