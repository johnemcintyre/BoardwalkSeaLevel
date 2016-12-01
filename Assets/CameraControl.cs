using UnityEngine;
using System.Collections;

public class CameraControl : MonoBehaviour {
	float speed = 10f;
	float lookSpeed = 100f;
//	float prevMouseX;
//	float prevMouseY;
	float yaw = 0f;
	float pitch = 0f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 translation = Vector3.zero;
		if (Input.GetKey (KeyCode.W)) {
			translation.y += speed * Time.deltaTime;
		}
		if (Input.GetKey (KeyCode.S)) {
			translation.y -= speed * Time.deltaTime;
		}
		if (Input.GetKey (KeyCode.D)) {
			translation.x += speed * Time.deltaTime;
		}
		if (Input.GetKey (KeyCode.A)) {
			translation.x -= speed * Time.deltaTime;
		}
		transform.Translate (translation);
//		Vector3 mousePos = mousePosition ();
//		float deltaX = mousePos.x - prevMouseX;
//		float deltaY = mousePos.y - prevMouseY;
//		Vector3 rotation = new Vector3 (
//			deltaY * lookSpeed * Time.deltaTime,
//			deltaX * lookSpeed * Time.deltaTime,
//			0f
//			);
//		Vector3 rotation = new Vector3(1, 0, 0);
//		print (Camera.main.WorldToScreenPoint(Input.mousePosition));
//		transform.rotation = transform.rotation + deltaRotation;
//		transform.Rotate(rotation);
//		prevMouseX = mousePos.x;
//		prevMouseY = mousePos.y;
		yaw += lookSpeed * Input.GetAxis("Mouse X") * Time.deltaTime;
		pitch -= lookSpeed * Input.GetAxis ("Mouse Y") * Time.deltaTime;
		transform.eulerAngles = new Vector3 (pitch, yaw, 0f);
	}

//	Vector3 mousePosition() {
//		return Camera.main.WorldToScreenPoint(Input.mousePosition);
//	}
}
