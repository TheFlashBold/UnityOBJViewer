using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMoverStuff : MonoBehaviour {

    public GameObject target;
    public float speedMod = 10.0f;
    public float minScale = 0.01f;
    public float maxScale = 1f;

    private Vector3 point;

    void Start()
    {
        point = target.transform.position;
        transform.LookAt(point);
    }

    void Update()
    {
        transform.RotateAround(target.transform.position, Vector3.up, speedMod * Time.deltaTime);

        float zoomValue = Input.GetAxis("Mouse ScrollWheel");

        if (zoomValue != 0)
        {
            target.transform.localScale += Vector3.one * zoomValue;
            target.transform.localScale = Vector3.Max(target.transform.localScale, new Vector3(minScale, minScale, minScale));
            target.transform.localScale = Vector3.Min(target.transform.localScale, new Vector3(maxScale, maxScale, maxScale));
        }
    }
}
