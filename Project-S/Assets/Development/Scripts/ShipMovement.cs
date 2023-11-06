using UnityEngine;
using UnityAtoms.BaseAtoms;
using UnityEngine.InputSystem;
using UnityEngine.UIElements;

public class ShipMovement : MonoBehaviour
{
    [SerializeField] private FloatVariable speed;

    private PlayerInputActions _playerInputActions;
    private BoxCollider _shipCollider;
    private Vector3 movePosition;

    private void Awake()
    {
        _shipCollider = GetComponent<BoxCollider>();
        _playerInputActions = new PlayerInputActions();
    }

    private void OnEnable()
    {
        _playerInputActions.Player.Enable();
        _playerInputActions.Player.Move.performed += HandleMovement;
    }

    private void OnDisable()
    {
        _playerInputActions.Player.Move.performed -= HandleMovement;
        _playerInputActions.Player.Disable();
    }

    private void FixedUpdate()
    {
        if (_playerInputActions.Player.Move.IsPressed())
        {
            transform.position += movePosition;
        }
    }

    private void LateUpdate()
    {
        HandleScreenBoundaries();
    }

    private void HandleMovement(InputAction.CallbackContext context)
    {
        Vector2 moveDirection = context.ReadValue<Vector2>();
        movePosition = new Vector3(moveDirection.x, moveDirection.y, 0) * speed.Value * Time.deltaTime;
    }

    private void HandleScreenBoundaries()
    {
        Vector2 screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, transform.position.z));

        float objectWidth = _shipCollider.bounds.extents.x;
        float objectHeight = _shipCollider.bounds.extents.y;

        Vector3 viewPosition = transform.position;
        viewPosition.x = Mathf.Clamp(viewPosition.x, screenBounds.x * -1 + objectWidth, screenBounds.x - objectWidth);
        viewPosition.y = Mathf.Clamp(viewPosition.y, screenBounds.y * -1 + objectHeight, screenBounds.y - objectHeight);

        transform.position = viewPosition;
    }
}