using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UpdateScore : MonoBehaviour
{
    // Start is called before the first frame update
    private TextMeshPro _textMeshPro;
    void Start()
    {
        _textMeshPro = GetComponent<TextMeshPro>();
    }

    // Update is called once per frame
    void Update()
    {
        _textMeshPro.SetText($"Score: {OnClick.Score}");
    }
    
}
