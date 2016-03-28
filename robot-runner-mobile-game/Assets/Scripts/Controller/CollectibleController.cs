using UnityEngine;
using System.Collections;

public class CollectibleController : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.Rotate(new Vector3(30, 30, 45) * Time.deltaTime);
	}
}
