using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGScroll : MonoBehaviour
{
    BoxCollider2D bgCollider;
    float colliderSize;
    Vector2 bgStartPos;

    // Start is called before the first frame update
    void Start()
    {
        bgCollider = GetComponent<BoxCollider2D>();
        bgStartPos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        colliderSize = bgCollider.size.x / 2;
        transform.Translate(Vector2.left * 1 * Time.deltaTime);
        if (transform.position.x < bgStartPos.x - colliderSize)
        {
            transform.position = bgStartPos;
        }
    }
}
