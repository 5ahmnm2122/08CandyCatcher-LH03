using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Candies : MonoBehaviour
{
    public float speed;
    private Rigidbody2D candyRB;
    public PlayerData data;
    public int points;

    void Start()
    {
        candyRB = this.GetComponent<Rigidbody2D>();
        candyRB.velocity = new Vector2(0, -speed);
    }

    void Update()
    {
        if (transform.position.y < -3)
        {
            Destroy(this.gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        data.score += points;
        Destroy(this.gameObject);
    }

}
