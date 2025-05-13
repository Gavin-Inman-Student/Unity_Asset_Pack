using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pusher : MonoBehaviour
{


    bool canPush = true;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        StartCoroutine(Push());
    }

    IEnumerator Push()
    {
        Rigidbody rb = GetComponent<Rigidbody>();
        if (canPush)
        {
            canPush = false;
            rb.velocity = new Vector3(transform.position.x, transform.position.y, 2);
            yield return new WaitForSeconds(2f);
            rb.velocity = new Vector3(transform.position.x, transform.position.y, - 2);
            yield return new WaitForSeconds(2f);
            canPush = true;
        }
    }
}
