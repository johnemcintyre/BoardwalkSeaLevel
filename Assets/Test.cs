using UnityEngine;
using System.Collections;

public class Test : MonoBehaviour
{
    float timeLimit = 6.0f; // 6 seconds.
    float scale = 0.1f;
    float speed = 1.0f;
    float noiseStrength = 1f;
    float noiseWalk = 1f;
    bool flag = true;

    private Vector3[] baseHeight;

    void Update()
    {

        // translate object for 10 seconds.
        if (timeLimit > 0)
        {
            // Decrease timeLimit.
            timeLimit -= Time.deltaTime;
        } else if (flag){ 
            noiseStrength = noiseStrength+.5f;
            transform.Translate(new Vector3 (0f,.5f,0f));
            flag = false;
        }

        Mesh mesh = GetComponent<MeshFilter>().mesh;

        if (baseHeight == null)
            baseHeight = mesh.vertices;

        Vector3[] vertices = new Vector3[baseHeight.Length];
        for (int i = 0; i < vertices.Length; i++)
        {
            Vector3 vertex = baseHeight[i];
            vertex.y += Mathf.Sin(Time.time * speed + baseHeight[i].x + baseHeight[i].y + baseHeight[i].z) * scale;
            vertex.y += Mathf.PerlinNoise(baseHeight[i].x + noiseWalk, baseHeight[i].y + Mathf.Sin(Time.time * 0.1f)) * noiseStrength;
            vertices[i] = vertex;
        }
        mesh.vertices = vertices;
        mesh.RecalculateNormals();
    }
}