using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdController : MonoBehaviour
{
    Rigidbody2D birdRb;
    [SerializeField] float force;

    // Start is called before the first frame update
    void Start()
    {
        birdRb = GetComponent<Rigidbody2D>();
        force = 5;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            birdRb.AddForce(Vector2.up * force, ForceMode2D.Impulse);
        }
    }

    public void Fly()
    {
        birdRb.AddForce(Vector2.up * force, ForceMode2D.Impulse);
    }
}
