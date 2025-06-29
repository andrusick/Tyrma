using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLayerController : MonoBehaviour
{
    [SerializeField]
    protected int defaultLayer = 3;
    [SerializeField]
    protected float rayLenth = 0.1f;

    protected Collider2D lastWall;
    protected SpriteRenderer spriteRenderer;

    protected virtual void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    protected virtual void Update()
    {
        if (IsUnderWall())
        {
            int newOrderInLayer = lastWall.GetComponent<SpriteRenderer>().sortingOrder + 1;
            spriteRenderer.sortingOrder = newOrderInLayer;
        }
        else
        {
            spriteRenderer.sortingOrder = defaultLayer;
        }

    }
    protected virtual bool IsUnderWall()
    {
        RaycastHit2D hit = Physics2D.Raycast(transform.position - new Vector3(0, 2, 0), Vector2.up, rayLenth, LayerMask.GetMask("Wall"));
        lastWall = hit.collider;
        return lastWall != null;
    }
}
