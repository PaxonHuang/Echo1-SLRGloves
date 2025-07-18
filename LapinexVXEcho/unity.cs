using UnityEngine;

public class RotatingCube : MonoBehaviour
{
    public float rotationSpeed = 50f;
    private GameObject cube;

    void Start()
    {
        // 创建一个正方体
        cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
        cube.transform.position = Vector3.zero;
    }

    void Update()
    {
        // 让正方体绕X和Y轴旋转
        if (cube != null)
        {
            cube.transform.Rotate(new Vector3(1, 1, 0) * rotationSpeed * Time.deltaTime);
        }
    }
}