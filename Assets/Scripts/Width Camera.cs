using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WidthCamera : MonoBehaviour
{
    private float _startAspect = 1600f / 900f;
    private float _defaultHeight, _defaultWidth;
    public GameObject JarInHouse;
    private CanvasScaler CanvasInHouse;

    private void Awake()
    {
        CanvasInHouse = JarInHouse.transform.GetChild(2).gameObject.GetComponent<CanvasScaler>();
        CanvasInHouse.matchWidthOrHeight = 1f;

        if (Camera.main.aspect < _startAspect)
        {
            CanvasInHouse.matchWidthOrHeight = 0f;
            _defaultHeight = Camera.main.orthographicSize;
            _defaultWidth = Camera.main.orthographicSize * _startAspect;

            Camera.main.orthographicSize = _defaultWidth / Camera.main.aspect;
        }
    }
}
