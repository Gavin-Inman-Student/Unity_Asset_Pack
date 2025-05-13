using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class won : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        ParticleSystem p = GetComponent<ParticleSystem>();
        if (other.CompareTag("Player"))
        {
            p.Play();
        }
    }
}
