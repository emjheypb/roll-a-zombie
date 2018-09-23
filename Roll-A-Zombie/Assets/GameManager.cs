using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

	public int selectedZombiePosition;
	public GameObject selectedZombie;
	public List<GameObject> zombies;
	public Vector3 selectedSize;
	public Vector3 defaultSize;

	void Start() {
		SelectZombie(zombies[0], 0);
	}

	void Update() {
		if(Input.GetKeyDown(KeyCode.LeftArrow)) {
			ShiftLeft();
		}
		if(Input.GetKeyDown(KeyCode.RightArrow)) {
			ShiftRight();
		}
		if(Input.GetKeyDown(KeyCode.UpArrow)) {
			PushUp();
		}
	}

	void ShiftLeft() {
		if(selectedZombiePosition == 0) {
			SelectZombie(zombies[3], 3);
		} else {
			SelectZombie(zombies[selectedZombiePosition - 1], selectedZombiePosition - 1);
		}
	}

	void ShiftRight() {
		if(selectedZombiePosition == 3) {
			SelectZombie(zombies[0], 0);
		} else {
			SelectZombie(zombies[selectedZombiePosition + 1], selectedZombiePosition + 1);
		}
	}

	void PushUp() {
		Rigidbody rb = selectedZombie.GetComponent<Rigidbody>();
		rb.AddForce(0, 0, 10, ForceMode.Impulse);
	}

	void SelectZombie(GameObject newZombie, int newPosition) {
		selectedZombie.transform.localScale = defaultSize;	
		selectedZombie = newZombie;
		selectedZombie.transform.localScale = selectedSize;
		selectedZombiePosition = newPosition;
	}
}
