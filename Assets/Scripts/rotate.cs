using UnityEngine;

public class rotate : MonoBehaviour
{
    // This script is attched to tthe wheel oF a windmill and rotates it 
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    [SerializeField]
    private Vector3 rotationSpeed = new Vector3(0, 20, 0); // Rotation speed in degrees per second

    void Start()
    {
        // Rotate the wheel around its local Y-axis at a speed of 20 degrees per second
        transform.Rotate(rotationSpeed * Time.deltaTime);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(rotationSpeed * Time.deltaTime);
    }
}
