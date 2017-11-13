using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lockRotation : MonoBehaviour {

	public int rotSpeed;
	void Update () {
		transform.Rotate(Vector3.one * rotSpeed * Time.deltaTime);
	}
}
