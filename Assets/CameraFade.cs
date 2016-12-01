using UnityEngine;
using System.Collections;

public class CameraFade : MonoBehaviour
{
    //tutorial
    //https://www.youtube.com/watch?v=0HwZQt94uHQ

    public Texture2D fadeOutTexture;
    public float fadeSpeed = 0.8f;
    private int drawDepth = -1000;
    private float alpha = 1.0f;
    private int fadeDir = -1;

    void OnGUI()
    {
        alpha += fadeDir * fadeSpeed * Time.captureFramerate;
        alpha = Mathf.Clamp01(alpha);

        //set GUI texture
        GUI.color = new Color(GUI.color.r, GUI.color.g, GUI.color.b, alpha);
        GUI.depth = drawDepth;
        GUI.DrawTexture(new Rect(0, 0, Screen.width, Screen.height), fadeOutTexture);
    }

    public float BeginFade(int direction) 
    {
        fadeDir = direction;
        return (fadeSpeed);
    }

    void OnLevelWasLoaded()
    {
        BeginFade(-1);

    }
}
