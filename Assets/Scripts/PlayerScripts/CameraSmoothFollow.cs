using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSmoothFollow : MonoBehaviour {

    public GameObject followObject;

    private Camera _cam;

    private Vector3 velocity = Vector3.zero;

    public float dampTime = 0.15f;


    void Start()
    {
        _cam = GetComponent<Camera>();
    }

    // Update is called once per frame
    void Update()
    {
        if (followObject)
        {
            Vector3 point = _cam.WorldToViewportPoint(followObject.transform.position);
            Vector3 delta = followObject.transform.position - _cam.ViewportToWorldPoint(new Vector3(0.5f, point.y, point.z)); //(new Vector3(0.5, 0.5, point.z));
            Vector3 destination = transform.position + delta;
            transform.position = Vector3.SmoothDamp(transform.position, destination, ref velocity, dampTime);
        }

    }
}
