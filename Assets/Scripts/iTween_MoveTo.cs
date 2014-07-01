using UnityEngine;
using System.Collections;

public class iTween_MoveTo : MonoBehaviour {
	
	private int x,y,z;
	private Vector3 initialPos;
	
	// Create GameObject holder for Bullets, assign Cube_Lazer on the Inspector
	public GameObject Bullet;	
	private Vector3 cubePos;
	
	
	// Use this for initialization
	void Start ()
	{
		initialPos = transform.position;
		cubePos = initialPos;
		x = (int)initialPos.x;
		y = (int)initialPos.y;
		z = (int)initialPos.z;
	}
	
	// Update is called once per frame
	void Update ()
	{		
		CubePosition();
		ShootAction ();
	}
	
	// Cube Left - Right
	void CubePosition ()
	{			
		if(Input.GetKey(KeyCode.RightArrow))
		{
			x++;
		}		
		else if(Input.GetKey(KeyCode.LeftArrow))
		{
			x--;
		}
		
		cubePos = new Vector3(x, y, z);
		gameObject.transform.position = cubePos;
	}
	
	
	// Cube Shoots
	void ShootAction ()
	{				
		if(Input.GetKeyDown(KeyCode.A))
		{			
			if(Bullet.activeSelf)
				Debug.Log("ShootAction: " + Bullet);
			// Create an instance of a GameObject of Bullet
			else
				Instantiate(Bullet, new Vector3(1,1,-3), Quaternion.identity);
		}
	}
}
