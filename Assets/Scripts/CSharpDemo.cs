using System.Collections;
using System.Collections.Generic;
using UnityEngine;

class GameObject2D
{
	string name;

	void setName(string _name)
	{
		name = _name;
	}

	string getName()
	{
		return name;
	}
}

public class CSharpDemo : MonoBehaviour {

	// Use this for initialization
	void Start () 
	{
		value_DataType ();	
		Debug.Log ("\n");
		reference_DataType ();
	}
	
	// Update is called once per frame
	void Update () 
	{
			
	}
		
	void value_DataType()
	{
		// ‘transform.position’ gives the position of the sphere
		Debug.Log ("x = " + transform.position.x + "  y = " 
			+ transform.position.y + "  z = " + transform.position.z);

		Vector3 v1 = transform.position;
		v1.x += 1f; v1.y += 1f; v1.z = +1f;

		Debug.Log ("x = " + v1.x + "  y = " 
			+ v1.y + "  z = " + v1.z);

		Debug.Log ("x = " + transform.position.x + "  y = " 
			+ transform.position.y + "  z = " + transform.position.z);

	} 

	void reference_DataType()
	{
		// ‘transform.position’ gives the position of the sphere
		Debug.Log ("x = " + transform.position.x + "  y = " 
			+ transform.position.y + "  z = " + transform.position.z);

		Transform trans = transform;

		// note that, here we change the ‘trans.position’, not ‘transform.position’
		trans.position = trans.position + new Vector3(1f, 1f, 1f);

		Debug.Log ("x = " + transform.position.x + "  y = " 
			+ transform.position.y + "  z = " + transform.position.z);

	} 

}
