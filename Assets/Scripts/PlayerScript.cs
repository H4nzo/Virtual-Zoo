using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class PlayerScript : MonoBehaviour
{
    [SerializeField] private float m_MoveSpeed = 5f;
    [SerializeField] private float m_TurnSpeed = 180f;
    [SerializeField] private float m_LookSpeed = 180f;
    [SerializeField] private float m_JumpForce = 5f;
    
    [SerializeField] private float m_YMinLimit = 20f;

private KeyCode m_JumpKey = KeyCode.Space;

    private Rigidbody m_Rigidbody;

    private float m_VerticalInput;
    private float m_HorizontalInput;
    private float m_LookInput;

    private void Awake()
    {
        m_Rigidbody = GetComponent<Rigidbody>();
        
    }

    private void Update()
    {
        m_VerticalInput = Input.GetAxis("Vertical");
        m_HorizontalInput = Input.GetAxis("Horizontal");

        if (Input.GetKeyDown(m_JumpKey))
        {
            m_Rigidbody.AddForce(Vector3.up * m_JumpForce, ForceMode.Impulse);
        }

        float mouseX = Input.GetAxis("Mouse X");
        transform.Rotate(Vector3.up, mouseX * m_TurnSpeed * Time.deltaTime);

        m_LookInput += Input.GetAxis("Mouse Y") * m_LookSpeed * Time.deltaTime;
        m_LookInput = Mathf.Clamp(m_LookInput, m_YMinLimit, 90f);
        Camera.main.transform.localRotation = Quaternion.Euler(-m_LookInput, 0f, 0f);
    }

   private void FixedUpdate()
{
    // Get the input for horizontal movement using A and D keys
    float horizontalMovement = Input.GetAxis("Horizontal");

    // Get the input for vertical movement using W and S keys
    float verticalMovement = Input.GetAxis("Vertical");

    // Calculate the movement vector
    Vector3 movement = (transform.forward * verticalMovement + transform.right * horizontalMovement) * m_MoveSpeed;

    // Set the y component of the movement vector to the current velocity of the rigidbody in the y direction
    movement.y = m_Rigidbody.velocity.y;

    // Set the velocity of the rigidbody
    m_Rigidbody.velocity = movement;
}

}

