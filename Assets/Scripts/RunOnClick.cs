using UnityEngine;

using Input = Wrappers.Input;

public class RunOnClick: MonoBehaviour
{
    private Actions _actions;
    private double _time;
    void Start()
    {
        _actions = GetComponent<Actions>();
        _time = 0.0;
    }

    void Update()
    {
        _time += Time.deltaTime;
        foreach (Touch touch in Input.touches)
        {
            if (touch.phase == TouchPhase.Began)
            {
                _actions.Run();
                _time = 0.0;
            }
        }
        if (_time > 1.0)
        {
            _actions.Walk();
        }
    }
}