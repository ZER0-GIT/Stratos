using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour
{
    public GameObject John;

    // Update is called once per frame
    void Update()
    {
        Vector3 position = transform.position;
        position.x = John.transform.position.x;
        position.y = John.transform.position.y;
        transform.position = position;

    }
}
