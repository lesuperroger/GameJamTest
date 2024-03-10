using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gravity : MonoBehaviour
{
    public Transform reffTrans;
    public Rigidbody2D reffBody;
    public Vector3 direction;
    public float attractionSpeed = 100f;
    private void OnTriggerEnter2D(Collider2D col)
    {
        Debug.Log("Enter");
        reffTrans = col.GetComponent<Transform>();
        reffBody = col.GetComponent<Rigidbody2D>();

    }
    private void OnTriggerStay2D(Collider2D col)
    {
        Vector3 playerPos = reffTrans.position;
        direction = (transform.position - playerPos).normalized * attractionSpeed;
        Debug.Log("stay");
        reffBody.AddForce(direction * Time.deltaTime, ForceMode2D.Force);
    }

}
