using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformController : MonoBehaviour
{
    [SerializeField] float xBound = 15;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.left * 5 * Time.deltaTime);
        if(transform.position.x < -xBound)
        {
            Destroy(gameObject);
        }
    }
}
