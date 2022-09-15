using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float movementForce = 0f;
    [SerializeField] private float jumpForce = 0f;
    private Rigidbody2D rb;
    private Vector3 startingPosition = Vector3.zero;
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        startingPosition = this.transform.position;
    }

    private void Update()
    {
        PlayerMovement();
    }

    private void PlayerMovement()
    {
        float movement = Input.GetAxis("Horizontal");
        transform.position += new Vector3(movement,0,0) * Time.deltaTime * movementForce;

        if (Input.GetButtonDown("Jump") && Mathf.Abs(rb.velocity.y) <= 0.00)
        {
            rb.AddForce(new Vector2(0,jumpForce),ForceMode2D.Impulse);
        }
    }

    private void OnTriggerEnter2D(Collider2D other) 
    {
        if(other.CompareTag("Coin"))
        {
            GameManager.Instance.GetUiManager().IncreaseScore();
            GameManager.Instance.GetUiManager().LoadNextScene();
        }
        if (other.CompareTag("Lava"))
        {
            this.transform.position = startingPosition;
            GameManager.Instance.GetUiManager().IncreaseDeathTimer();
        }
    }
}
