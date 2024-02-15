using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    [SerializeField] private Transform player;
    [SerializeField] private float speed;
    [SerializeField] private float rotateForward;
    [SerializeField] private float rotateBack;
    private Rigidbody2D rb;
    private bool forwardspeed = false;
    private bool backwardspeed = false;
    private bool rotateforward = false;
    private bool rotateback = false;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    private void FixedUpdate()
    {
        if (forwardspeed == true)
        {
            rb.AddForce(Vector2.right * speed);
        }
        if (backwardspeed == true)
        {
            rb.AddForce(Vector2.right * -speed);
        }
        if (rotateforward == true)
        {
            player.Rotate(0, 0, rotateForward * Time.deltaTime);
        }
        if (rotateback == true)
        {
            player.Rotate(0, 0, rotateBack * Time.deltaTime);
        }
    }
    public void Forward(bool _forward)
    {
       forwardspeed = _forward;
    }
    public void Backward(bool _backward)
    {
        backwardspeed = _backward;
    }
    public void RotateForward(bool _rotateForward)
    {
        rotateforward = _rotateForward;
    }
    public void RotateBack(bool _rotateBack)
    {
        rotateback = _rotateBack;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Flag"))
        {
            Debug.Log("Complete");
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
       if (collision.otherCollider.CompareTag("Ground"))
        {           
          Debug.Log("Touching");   
        }
    }
}
