using UnityEngine;
using UnityEngine.InputSystem;

[RequireComponent(typeof(Rigidbody), typeof(CapsuleCollider))]
public class Controller : MonoBehaviour
{
    #region Value

    private Rigidbody rb;
    private Transform cam;

    [Header("Gamepad")] [SerializeField] private float moveSpeed;
    [SerializeField] private float rotSpeed, jumpForce;
    [SerializeField] private float groundCheckDistance = 1;
    [SerializeField] private float lookDistance = 1;

    private Transform originTransform, movementTransform;
    private Vector3 moveDir, rotDir;
    private bool isGrounded = true;
    private readonly float timeBetweenJumps = 0.5f;
    private float currentTime;

    #endregion

    #region MonoBehaviour Functions

    private void Start()
    {
        rb = GetComponent<Rigidbody>();

        cam = Camera.main.transform;

        originTransform = transform;

        movementTransform = new GameObject("MoveTransform").transform;
        movementTransform.position = originTransform.position;
        movementTransform.rotation = originTransform.rotation;
    }

    private void Update()
    {
        movementTransform.rotation = Quaternion.Euler(0, cam.rotation.eulerAngles.y, 0);
        originTransform.Rotate(Vector3.up, rotDir.x * rotSpeed * Time.deltaTime);

        originTransform.position +=
            (movementTransform.right * moveDir.x + movementTransform.forward * moveDir.y).normalized *
            moveSpeed * Time.deltaTime;

        if (currentTime < timeBetweenJumps)
            currentTime += Time.deltaTime;
        else if (Physics.Raycast(originTransform.position + Vector3.up * 0.1f, Vector3.down, out RaycastHit hit,
            groundCheckDistance))
            isGrounded = hit.transform.CompareTag("Ground");
    }

    #endregion

    #region In

    public void Jump(InputAction.CallbackContext context)
    {
        if (!context.started) return;

        //Debug.Log("Jump");

        if (isGrounded)
        {
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            isGrounded = false;
            currentTime = 0;
        }
    }

    public void Move(InputAction.CallbackContext context)
    {
        //Debug.Log(context.ReadValue<Vector2>());
        moveDir = context.ReadValue<Vector2>();
    }

    public void Rot(InputAction.CallbackContext context)
    {
        //Debug.Log(context.ReadValue<Vector2>());
        rotDir = context.ReadValue<Vector2>();
    }

    public void Interact(InputAction.CallbackContext context)
    {
        if (!context.started) return;

        //Debug.Log("Interact");

        if (Physics.Raycast(cam.position, cam.forward, out RaycastHit hit, lookDistance))
        {
            foreach (IInteractable interactable in hit.transform.GetComponents<IInteractable>())
                interactable.Trigger();
        }
    }

    #endregion
}