using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BloodSpinny : MonoBehaviour
{
    public float rotateSpeed = 45f;

    void Update()
    {
        transform.Rotate(0f, 0f, rotateSpeed * Time.deltaTime); // Z-axis
    }
}
