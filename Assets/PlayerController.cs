using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class PlayerController : MonoBehaviour
{
    [SerializeField]
    private float speed;
    private Rigidbody2D rb;
    private Vector2 direction;
    private float horizontalInput;
    private float verticalInput;
    protected bool isMove = true;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if(isMove == true)
        {
            Move();
        }

        

    }
     void Move()
     {
        horizontalInput = Input.GetAxisRaw("Horizontal");
        verticalInput = Input.GetAxisRaw("Vertical");

        direction = new Vector2(horizontalInput, verticalInput).normalized;

     }

    void FixedUpdate()
    {
        rb.velocity = direction * speed;
    }
}
