using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hammer : MonoBehaviour
{

    bool canCrush = true;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        StartCoroutine(Crush());
    }

    IEnumerator Crush()
    {
        if (canCrush)
        {
            canCrush = false;
            transform.rotation = Quaternion.Euler(-90, 0, 0);
            yield return new WaitForSeconds(2);
            transform.rotation = Quaternion.Euler(0, 0, 0);
            yield return new WaitForSeconds(2);
            canCrush = true;
        }
    }
}
