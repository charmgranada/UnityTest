using UnityEngine;
using System.Collections;

public class DetectCollision : MonoBehaviour {
	
	
	void OnCollisionEnter(Collision c)
	{
		Debug.Log("Enter Collision");
	}
		
	
	void OnCollisionStay(Collision c)
	{
		Debug.Log("Collision Stays");
	}
	
	
	void OnCollisionExit(Collision c)
	{
		Debug.Log("Exit Collision");
	}
}
