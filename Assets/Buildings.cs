using UnityEngine;
using System.Collections;

public class Buildings : MonoBehaviour {

    float moveSpeed = .5f;
	
	// Update is called once per frame
	void Update () {

        transform.Translate(Vector3.right * moveSpeed * Time.deltaTime);
    }
}
