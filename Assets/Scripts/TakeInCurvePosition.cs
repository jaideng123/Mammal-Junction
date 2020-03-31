using UnityEngine;

[ExecuteInEditMode]
public class TakeInCurvePosition : MonoBehaviour
{
    private Material material;
    private Mesh mesh;
    private void OnEnable()
    {
        material = GetComponent<Renderer>().sharedMaterial;
        mesh = GetComponent<MeshFilter>().sharedMesh;
    }
    private void Update()
    {
        Vector4 position = CurvePosition.position;
        material.SetVector("_CurvePosition", position);
        // Hacky way to make sure we don't cull this too early 
        // Should be replaced with a calculation that mirrors the curve
        mesh.bounds = new Bounds(Vector3.zero, Vector3.one * 100f);
    }
}