using UnityEngine;
using System.Collections;

public class CameraSplice : MonoBehaviour {
	Camera one;
	Camera two;
	Camera three;
	Camera four;

	// Use this for initialization
	void Start () {
		one = GameObject.Find ("Camera One").GetComponent<Camera>();
		one.enabled = true;
		one.rect = new Rect (new Vector2 (0, 0), new Vector2 (1f / 3f, 1));
		two = GameObject.Find ("Camera Two").GetComponent<Camera>();
		two.enabled = true;
		two.rect = new Rect (new Vector2 (1f / 3f, 0), new Vector2 (1f / 3f, 1));
		three = GameObject.Find ("Camera Three").GetComponent<Camera>();
		three.enabled = true;
		three.rect = new Rect (new Vector2 (2f / 3f, 0), new Vector2 (1f / 3f, 1));
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
