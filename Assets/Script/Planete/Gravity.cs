using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gravity : MonoBehaviour
{
    public Transform reffTrans;
    public Rigidbody2D reffBody;
    public CircleCollider2D gravityCircle;
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
        //difference entre point x et y;
        Vector3 difference = transform.position - playerPos;
        //distance entre les deux points
        float distance = difference.magnitude;
        float massePlanette = (gravityCircle.radius * 100);
        //Équation de la gravité : F = Gavité * masse1 * masse2 / distance.pow(2),
        float relativeAttractionSpeed = (attractionSpeed * massePlanette) / Mathf.Pow(distance, 2);
        Vector3 direction = difference.normalized;
        Debug.Log("stay");
        reffBody.AddForce(direction * Time.deltaTime * relativeAttractionSpeed, ForceMode2D.Force);
    }

}
