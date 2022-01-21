using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public bool canMove = true;

    [SerializeField]
    float maxPos;

    [SerializeField]
    float speed;

    void Update()
    {
        if (canMove)
        {
            Move();
        }
    }

    public void Move()
    {
        float input = Input.GetAxis("Horizontal");
        transform.position = transform.position + Vector3.right * input * speed * Time.deltaTime;
        float xPos = Mathf.Clamp(transform.position.x, -maxPos, maxPos);
        transform.position = new Vector3(xPos, transform.position.y, transform.position.z);
    }

}
