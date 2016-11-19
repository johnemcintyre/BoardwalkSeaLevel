using UnityEngine;
using System.Collections;

public class Rides : MonoBehaviour
{

    float moveSpeed = 50f;

    // Update is called once per frame
    void Update()
    {

        transform.Rotate(Vector3.up, moveSpeed * Time.deltaTime);
    }
}
