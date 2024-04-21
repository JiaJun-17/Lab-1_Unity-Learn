using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    public MeshRenderer Renderer;
    public float transformPositionX = 3.0f;
    public float transformPositionY = 4.0f;
    public float transformPositionZ = 1.0f;
    public float changeScale = 1.5f;
    public float rotationalAngle = 10.0f;
    public float rotationalSpeed = 10.0f;
    
    void Start()
    {
        transform.position = new Vector3(transformPositionX, transformPositionY, transformPositionZ);
        transform.localScale = Vector3.one * changeScale;
        
        Material material = Renderer.material;
        
        material.color = new Color(0.5f, 1.0f, 0.3f, 0.4f);
    }
    
    void Update()
    {
        transform.Rotate(rotationalAngle * Time.deltaTime * rotationalSpeed, 0.0f, 0.0f);
    }
}
