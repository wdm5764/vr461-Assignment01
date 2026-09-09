using UnityEngine;
using UnityEngine.InputSystem;

public class Character : MonoBehaviour
{
	InputAction moveAction;

	private CharacterController characterController;
	public float speed = 15f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
		characterController = GetComponent<CharacterController>();
		moveAction = InputSystem.actions.FindAction("Move");
    }

    // Update is called once per frame
    void Update()
    {
		Vector2 moveValue = moveAction.ReadValue<Vector2>();
		Vector3 move = new Vector3(moveValue.x,0,moveValue.y);
		characterController.Move(move*Time.deltaTime*speed);
    }
}
