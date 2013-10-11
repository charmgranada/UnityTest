using UnityEngine;
using System.Collections;

public class DetectTrigger : MonoBehaviour {

	void OnTriggerEnter(Collider collider){
		Debug.Log("Object Enters Trigger: " + collider);
		collider.gameObject.SetActive(false);
	}
}
