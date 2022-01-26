using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField]
    float maxPos;

    [SerializeField]
    float speed;

    //Calls upon move method and lets cat move
    void Update()
    {
        Move();
    }

    //Calculates the movement of the cat on the horizontal axis
    public void Move()
    {
        float input = Input.GetAxis("Horizontal");
        transform.position = transform.position + Vector3.right * input * speed * Time.deltaTime;
        float xPos = Mathf.Clamp(transform.position.x, -maxPos, maxPos);
        transform.position = new Vector3(xPos, transform.position.y, transform.position.z);
    }

}
