using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    GameObject spawner;

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

        if (transform.position.y < -100)
        {
            transform.position = spawner.transform.position;
        }
    }

    void Move()
    {
        float movX = Input.GetAxisRaw("Vertical");
        Rigidbody rb = GetComponent<Rigidbody>();

        rb.velocity = new Vector3 (movX * 5, rb.velocity.y, rb.velocity.z);
    }
}
