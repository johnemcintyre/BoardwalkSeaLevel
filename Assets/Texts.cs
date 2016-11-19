using UnityEngine;

using UnityEngine.UI;
using System.Collections;

public class Texts : MonoBehaviour
{

    Text someText;
    bool flag = true;
    float timeLimit = 6.0f; // 6 seconds.
    void Start() {

        someText = GetComponent<Text>();
    }
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

            someText.text = "2030";
            flag = false;
        }
    }
}
