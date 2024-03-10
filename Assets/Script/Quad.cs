using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Quad : MonoBehaviour
{
    [SerializeField] Rigidbody2D player;
    [SerializeField] Renderer background;
    [SerializeField] float scailX = 0.028f;
    [SerializeField] float scailY = 0.041f;
    // Update is called once per frame
    void Update()
    {
        background.material.mainTextureOffset += new Vector2((player.velocity.x) * Time.deltaTime, 0) * scailX;
        background.material.mainTextureOffset += new Vector2(0, (player.velocity.y) * Time.deltaTime) * scailY;
    }
}
