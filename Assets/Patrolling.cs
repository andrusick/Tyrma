using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Patrolling : MonoBehaviour
{
    [SerializeField]
    private float speed;
    private Rigidbody2D rb;
    private Vector2 direction;
    public bool Vector
    {
        get { return vector; }
        set { vector = value; }
    }
    protected bool vector = true;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (vector == true)
        {
            direction = Vector2.left;
        }
        else
        {
            direction = Vector2.right;
        }

        Moving();
    }
    void Moving()
    {
        rb.velocity = direction * speed;
    }
    void OnDisable()
    {
        rb.velocity = Vector2.zero;
        Debug.Log("ww");
    }
}
