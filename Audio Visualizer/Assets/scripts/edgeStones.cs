using UnityEngine;
using System.Collections;

public class edgeStones : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnCollisionEnter(Collision colEnter)
	{
		if(colEnter.collider.CompareTag("theBlock"))
		{
			//landed = true;
		}
	}
}
