using UnityEngine;

using Input = Wrappers.Input;
public class MovingFloor : MonoBehaviour
{
    private float _maxV;
    private double _time;
    private float _a;
    private float _v;

    private void Start()
    {
        _time = 0.0;
        _maxV = 1.0f;
        _a = 0.1f;
        _v = 1.0f;
    }

    private void setV()
    {
        _v = (_v + _a) <= 3.0f && (_v + _a) >= 1.0f ? _v + _a : _v < 1.0f ? 1.0f : 3.0f;
    }

    private void Update()
    {
        setV();
        gameObject.transform.Translate(-Time.deltaTime * _v, 0, 0);
        _time += Time.deltaTime;
        if (gameObject.transform.position.x <= -5) gameObject.transform.Translate(10, 0, 0);

        foreach (var touch in Input.touches)
            if (touch.phase == TouchPhase.Began)
            {
                _a = 0.1f;
                _time = 0.0;
            }
        if (_time > 1.1) _a = -0.1f;
    }
}