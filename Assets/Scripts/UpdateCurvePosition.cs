using UnityEngine;

[ExecuteInEditMode]
public class UpdateCurvePosition : MonoBehaviour
{
    private void Update()
    {
        CurvePosition.position = transform.position;
    }
}