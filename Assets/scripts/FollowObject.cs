using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [SerializeField] private float transitionSpeed;
    [SerializeField] private Transform target;
    [SerializeField] private float positionZ;
    // Update is called once per frame
    void Update()
    {
        Vector3 newPos = new Vector3(target.position.x, target.position.y, positionZ);
        transform.position = newPos;
    }
}
