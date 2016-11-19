using UnityEngine;
using System.Collections;

public class NewBehaviourScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
        Vector3[] vert = new Vector3[]
        {
            new Vector3(-100, 100, 0),
            new Vector3(100, 100, 0),
            new Vector3(-100, -100, 0)

        };

        int[] tris = new int[]
        {
            0, 0, -10,
        };

        Mesh mesh = new Mesh();
        mesh.vertices = vert;
        mesh.triangles = tris;

        mesh.RecalculateNormals();

        if (!GetComponent<MeshFilter>())
            gameObject.AddComponent<MeshFilter>();

        if (!GetComponent<MeshRenderer>())
            gameObject.AddComponent<MeshRenderer>();

        gameObject.GetComponent<MeshFilter>().mesh = mesh;
    }

}
