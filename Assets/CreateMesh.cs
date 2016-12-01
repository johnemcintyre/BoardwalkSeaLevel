using UnityEngine;
using System.Collections;

public class CreateMesh : MonoBehaviour {
	float size = 20f;
//	int divisions = 2;
	int xSize = 10;
	int ySize = 10;

	// Use this for initialization
	void Start () {
		Mesh mesh = new Mesh ();
		mesh.name = "Scripted_Plane_New_Mesh";

//		mesh.vertices = new Vector3[] {
//						new Vector3(-size, -size, 0.01f),
//						new Vector3(size, -size, 0.01f),
//						new Vector3(size, size, 0.01f),
//						new Vector3(-size, size, 0.01f) };
//		mesh.uv = new Vector2[] {
//					new Vector2(0, 0),
//					new Vector2(0, 1),
//					new Vector2(1, 1),
//					new Vector2(1, 0)} ;
//		mesh.triangles = new int[] {0, 1, 2, 0, 2, 3};

//		Vector3[] vertices = new Vector3[divisions * divisions];
//		for (int i = 0; i < divisions; i++) {
//			for (int j = 0; j < divisions; j++) {
//				vertices [i + j] = new Vector3 (-size + (i / divisions) * 2f * size,
//					-size + (j / divisions) * 2f * size, 0.01f);
//			}
//		}
//		mesh.vertices = vertices;
//		Vector2[] uvs = new Vector2[divisions * divisions];
//		for (int i = 0; i < divisions; i++) {
//			for (int j = 0; j < divisions; j++) {
//				uvs[i + j] = new Vector2 (i, j);
//			}
//		}
//		mesh.uv = uvs;
//		int[] triangles = new int[divisions * divisions * 2 * 3];
//		mesh.triangles = new int[] {0, 1, 2, 0, 2, 3};

		mesh.RecalculateNormals();
//		GameObject go = new GameObject("New_Plane_From_Script", MeshRenderer, MeshFilter, MeshCollider);
		GameObject go = new GameObject();
		go.name = "New_Plane_From_Script";
		go.AddComponent<MeshRenderer> ();
		go.AddComponent<MeshFilter> ();
		go.AddComponent<MeshCollider> ();
		go.GetComponent<MeshFilter>().mesh = mesh;
		go.GetComponent<MeshRenderer> ().material = (Material)Resources.Load ("water_material");
		go.transform.rotation = Quaternion.Euler (new Vector3 (-20f, 180f, 0));
		go.transform.Translate (new Vector3 (0, 10f, -25f));
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
