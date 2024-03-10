using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gravity : MonoBehaviour
{
    public Transform reff;
    public bool enAttente;
    public Vector3 direction;
    public float attractionSpeed = 100f;
    private void OnTriggerEnter2D(Collider2D col)
    {
        reff = col.GetComponent<Transform>();
        direction = gameObject.transform.position - reff.position;
        direction.Normalize();
    }
    private void OnTriggerStay2D(Collider2D col)
    {
        if (!enAttente)
        {
            Attraction();
        }
    }
    public void Attraction()
    {
        enAttente = true;
        Vector3 movement = direction * attractionSpeed * Time.deltaTime;
        reff.Translate(movement);
        enAttente = false;
    }
}
