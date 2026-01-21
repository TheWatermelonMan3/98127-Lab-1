using UnityEngine;
using UnityEngine.InputSystem;

public class Demo : MonoBehaviour
{
    Rigidbody rb;
    [SerializeField] float jumpForce = 5f;
    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        print("Hello World");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Jump(InputAction.CallbackContext context)
    {
        if(context.performed) {
            print("JUMP");
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
        }
    }
}
