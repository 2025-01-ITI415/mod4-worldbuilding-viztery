using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GarlicSpin : MonoBehaviour
{
    public float rotateSpeed = 90f;

    void Update()
    {
        transform.Rotate(Vector3.up * rotateSpeed * Time.deltaTime);
    }
}
