using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public bool movement = true;

    [SerializeField]
    float maxPos;

    [SerializeField]
    float moveSpeed;

    // Update is called once per frame
    void Update()
    {
        if (movement)
        {
            PlayerMove();
        }
    }

    private void PlayerMove()
    {
        float inputX = Input.GetAxis("Horizontal");
        transform.position = transform.position + Vector3.right * inputX * moveSpeed * Time.deltaTime;

        float xPos = Mathf.Clamp(transform.position.x, -maxPos, maxPos);
        transform.position = new Vector3(xPos, transform.position.y, transform.position.y);
    }
}
