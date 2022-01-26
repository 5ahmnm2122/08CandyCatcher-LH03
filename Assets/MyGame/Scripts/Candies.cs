using UnityEngine;

public class Candies : MonoBehaviour
{
    public float speed;
    private Rigidbody2D candyRB;
    public PlayerData data;
    public int points;

    //Get the rigidbody of the candy and calculate the falling velocity of candy
    void Start()
    {
        candyRB = this.GetComponent<Rigidbody2D>();
        candyRB.velocity = new Vector2(0, -speed);
    }

    //Destroy candy when it has reached a certain y position
    void Update()
    {
        if (transform.position.y < -3)
        {
            Destroy(this.gameObject);
        }
    }

    //On contact with the cat, destroy the candy and add or subtract points
    private void OnTriggerEnter2D(Collider2D other)
    {
        data.score += points;
        Destroy(this.gameObject);
    }

}
