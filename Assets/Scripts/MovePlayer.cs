using UnityEngine;

public class MovePlayer : MonoBehaviour
{
    public float speed = 1f;
    private void Update()
    {
        Vector3 direction = new Vector3();
        if (Input.GetKey(KeyCode.W))
        {
            direction.x += -1;
        }
        if (Input.GetKey(KeyCode.S))
        {
            direction.x += 1;
        }
        if (Input.GetKey(KeyCode.A))
        {
            direction.z += -1;
        }
        if (Input.GetKey(KeyCode.D))
        {
            direction.z += 1;
        }
        transform.Translate(direction.normalized * Time.deltaTime * speed);
    }
}