using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodMovement : MonoBehaviour
{
    public float foodSpeed;

    void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * foodSpeed);
    }
}
