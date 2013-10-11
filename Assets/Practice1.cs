using UnityEngine;
using System.Collections;

public class Practice1 : MonoBehaviour {
	
	public GameObject another;
	public int xPos;
	
	// Use this for initialization
	void Start () {
		another.transform.localPosition = new Vector3((float)xPos, 2, 2);
		//Debug.Log((float)another.transform.localPosition.x);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
