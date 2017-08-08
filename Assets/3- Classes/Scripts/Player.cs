using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    // <access-specifier> <data-type> <variable-name> <optional-initialization>
    public int lives = 3;
    public float rotationSpeed = 5f;
    public float acceleration = 50f;
    public float deceleration = 0.1f;

    private Rigidbody2D rigid2D; //default value null

    // Use this for initialization
    void Start()
    {
        rigid2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        // if user presses 'W'
        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))
        {
            rigid2D.AddForce(transform.right * acceleration);
        }
        // if user presses 'S'
        if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))
        {
            rigid2D.AddForce(-transform.right * acceleration);
        }
        // if user presses 'A'
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Rotate(Vector3.forward, rotationSpeed);
        }
        // if user presses 'D'
        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            transform.Rotate(-Vector3.forward, rotationSpeed);
        }
        // decelarating
        rigid2D.velocity += -rigid2D.velocity * deceleration;
    }
}
