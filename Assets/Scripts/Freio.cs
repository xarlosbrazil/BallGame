using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Freio : MonoBehaviour
{
    [SerializeField] public float freio;
    private Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (rb.velocity != Vector2.zero)
        {
            rb.velocity *= freio;
        }
    }
}
