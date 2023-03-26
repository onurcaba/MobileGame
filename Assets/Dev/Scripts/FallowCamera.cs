using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallowCamera : MonoBehaviour
{
    float cameraSpeed = 2.0f;
    Camera _camera;
    Vector3 cameraOffset= Vector3.zero;

    private void Start()
    {
        _camera = Camera.main;
        cameraOffset = _camera.transform.position - transform.position;
    }
    private void LateUpdate()
    {
        _camera.transform.position = Vector3.Slerp(_camera.transform.position,  transform.position + cameraOffset, Time.deltaTime * cameraSpeed);
    }
}
