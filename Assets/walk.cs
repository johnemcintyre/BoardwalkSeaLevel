using UnityEngine;
using System.Collections;

public class walk : MonoBehaviour
{

    float moveSpeed = Random.Range(-8f, 8f);
    bool flag = true;
    float timeLimit = 6.0f; // 6 seconds.

    // Update is called once per frame
    void Update()
    {

        // translate object for 10 seconds.
        if (timeLimit > 0)
        {
            // Decrease timeLimit.
            timeLimit -= Time.deltaTime;
        }
        else if (flag)
        {

            transform.position = new Vector3(Random.Range(-20f,20f), 2f, Random.Range(-15f, -10f));
            flag = false;
        }
        transform.Translate(Vector3.right * moveSpeed * Time.deltaTime);
    }
}
