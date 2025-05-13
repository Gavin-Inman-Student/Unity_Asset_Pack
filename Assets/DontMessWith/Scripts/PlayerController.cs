using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    GameObject spawner;
    bool grounded = true;

    // Start is called before the first frame update
    void Start()
    {
        spawner = GameObject.FindWithTag("Spawner").gameObject;
        transform.position = spawner.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        Move();
        Jump();

        if (transform.position.y < -100)
        {
            transform.position = spawner.transform.position;
        }
    }

    void Move()
    {
        float movX = Input.GetAxisRaw("Vertical");
        float movZ = Input.GetAxisRaw("Horizontal");
        Rigidbody rb = GetComponent<Rigidbody>();

        rb.velocity = new Vector3 (movX * 5, rb.velocity.y, rb.velocity.z);
    }

    void Jump()
    {
        if (Input.GetKey(KeyCode.Space) && grounded)
        {
            Rigidbody rb = GetComponent<Rigidbody>();
            rb.velocity = new Vector3(rb.velocity.x, 4, rb.velocity.z);
            grounded = false;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Floor"))
        {
            grounded = true;
        }
        else
        {
            grounded = false;
        }
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Floor"))
        {
            grounded = true;
        }
    }
}
