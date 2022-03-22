using UnityEngine;

using Input = Wrappers.Input;
public class MovingFloor : MonoBehaviour
{
    private float _coef;
    private double _time;
    private float _a;
    private float _v;

    private void Start()
    {
        _time = 0.0;
        _coef = 1.0f;
        _a = 1.1f;
        _v = 0.0f;
    }

    private void Update()
    {
        if (_v < _coef - _a) _v += _a;
        else if (_v > _coef + _a) _v -= _a;
        gameObject.transform.Translate(-Time.deltaTime * _v, 0, 0);
        _time += Time.deltaTime;
        if (gameObject.transform.position.x <= -5) gameObject.transform.Translate(10, 0, 0);

        foreach (var touch in Input.touches)
            if (touch.phase == TouchPhase.Began)
            {
                _coef = 3.0f;
                _time = 0.0;
            }
        if (_time > 1.1) _coef = 1.0f;
    }
}