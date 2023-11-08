using UnityEngine;

public class CarController : MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField] private float _rotationSpeed;
    [SerializeField] private Transform cameraHolder;

    private void Update()
    {
        var position = transform.position;
        var step = _speed * Time.deltaTime;
        var rotationStep = _rotationSpeed * Time.deltaTime;

       

        if (Input.GetKey(KeyCode.W))
        {
            position -= transform.right * step; 
        }
        if (Input.GetKey(KeyCode.S))
        {
            position += transform.right * step; 
        }

        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(Vector3.up, -rotationStep); 
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(Vector3.up, rotationStep); 
        }

        transform.position = position;
        
        cameraHolder.position = transform.position;
    }
}