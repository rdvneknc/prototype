using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{

    void Update()
    {
        if (transform.position.z >= 42)
        {
            Destroy(gameObject);
        }

        else if (transform.position.z <= -17)
        {
            Destroy(gameObject);
        }
    }
}
