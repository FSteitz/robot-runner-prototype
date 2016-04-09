using UnityEngine;
using System.Collections;

public class CollectibleController : MonoBehaviour {
	
	// Update is called once per frame
	void Update () {
		transform.Rotate(new Vector3(30, 30, 45) * Time.deltaTime);
	}
}
