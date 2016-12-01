using UnityEngine;
using System.Collections;

public class EventHandler : MonoBehaviour {

    public float CameraChange = 2f;
    private float timer = 0f;
    private bool fadingFlag = false;
    public Camera newCam;
    public Camera currentCam;
    // Update is called once per frame
    void Update () {
        
        if (timer > CameraChange) {
            changeCam();
            print("change");
            fadingFlag = true;
        }
        timer += Time.deltaTime;

        
	}
    void changeCam()
    {
       // float fadeTime = this.gameObject.GetComponent<CameraFade>().BeginFade(1);
        //yield return new WaitForSeconds(.8f);
        newCam.enabled = true;
        currentCam.enabled = false;
    }
}
