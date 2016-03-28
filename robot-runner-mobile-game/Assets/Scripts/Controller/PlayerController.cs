using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

	private const string COLLECTIBLE_TAG = "Collectible";

	public float movementVelocity = 25.0f;
	public float jumpVelocity = 8.0f;
	public float gravity = 9.8F;

	public GameObject leftLanePosition;
	public GameObject middleLanePosition;
	public GameObject rightLanePosition;

	private CharacterController character;
	private float defaultHeight;
	private float jumpHeight;

	private bool moveLeft = false;
	private bool moveRight = false;
	private bool isMoving = false;

	private Vector3 targetDirection;
	private GameObject targetLanePosition;

	void Start() {
		character = GetComponent<CharacterController>();
		defaultHeight = character.height;
		jumpHeight = character.height / 2;
	}

	void Update() {
		Vector3 moveDirection = Vector3.zero;

		if (character.isGrounded) {
			if (!isMoving) {
				if (Input.GetKey(KeyCode.LeftArrow)) {
					targetDirection = Vector3.left;
					moveLeft = true;
				} else if (Input.GetKey(KeyCode.RightArrow)) {
					targetDirection = Vector3.right;
					moveRight = true;
				}
			}
			 
			if (Input.GetKey(KeyCode.Space)) {
				moveDirection.y = jumpVelocity;
			}
		}
    
		if (!isMoving && (moveLeft || moveRight)) {
			isMoving = true;

			if (isOnLane(middleLanePosition)) {
				targetLanePosition = (moveLeft) ? leftLanePosition : rightLanePosition;
			} else if (isOnLane(leftLanePosition) && !moveLeft) {
				targetLanePosition = middleLanePosition;
			} else if (isOnLane(rightLanePosition) && !moveRight) {
				targetLanePosition = middleLanePosition;
			} else {
				resetMovementState();
			}
		}

		if (isMoving) {
			moveDirection += moveToLane(targetLanePosition, targetDirection);			
		}

		moveDirection.y -= gravity * Time.deltaTime;

		moveDirection += Vector3.forward;
		moveDirection = transform.TransformDirection(moveDirection);
		moveDirection *= movementVelocity;

		character.Move(moveDirection * Time.deltaTime);
		moveLanePositionsForward();
	}

	void OnTriggerEnter(Collider other) {
		if (other.gameObject.CompareTag(COLLECTIBLE_TAG)) {
			other.gameObject.SetActive(false);
		}
	
	}

	private void moveLanePositionsForward() {
		Vector3 forwardMovement = Vector3.forward * movementVelocity * Time.deltaTime;

		leftLanePosition.transform.Translate(forwardMovement);
		middleLanePosition.transform.Translate(forwardMovement);
		rightLanePosition.transform.Translate(forwardMovement);
	}

	private Vector3 moveToLane(GameObject lanePosition, Vector3 moveVector) {
		Vector3 moveOffset = calculateDistance(lanePosition);
		Vector3 moveDirection = moveOffset.normalized * movementVelocity;
		Vector3 targetPosition = Vector3.zero;

		if (moveDirection.sqrMagnitude < moveOffset.sqrMagnitude) {
			targetPosition.x = moveDirection.x;
		}

		if (isOnLane(lanePosition)) {
			resetMovementState();
		}

		return targetPosition;
	}

	private bool isOnLane(GameObject lanePosition) {
		return Mathf.Abs(calculateDistance(lanePosition).x) < 0.1;
	}

	private Vector3 calculateDistance(GameObject lanePosition) {
		return lanePosition.transform.position - transform.position;
	}

	private void resetMovementState() {
		targetLanePosition = null;

		moveLeft = false;
		moveRight = false;
		isMoving = false;
	}
}
