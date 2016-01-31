using UnityEngine;
using System.Collections;

public class theBlock : MonoBehaviour {

	public float moveSpeed = 5;
	public float scaleSpeed = 1.1f;
	bool landed = false;
	Vector3 scale = Vector3.zero;
	Vector3 beatSize = Vector3.zero;
	public Transform mesh;

	void Start ()
	{
		scale = mesh.transform.localScale;
		beatSize = new Vector3(1,0.5f,1);
	}
	
	// Update is called once per frame
	void Update ()
	{
		if(!landed)transform.position += transform.forward*moveSpeed*Time.deltaTime;
		else{
			mesh.transform.localScale = Vector3.Lerp(mesh.transform.localScale, scale, scaleSpeed*Time.deltaTime);
		}
	}

	void OnCollisionEnter(Collision colEnter)
	{
		if(colEnter.collider.CompareTag("edgeStone"))
		{
			landed = true;
			Destroy( transform.GetComponent<Rigidbody>() );
			AudioProcessor processor = FindObjectOfType<AudioProcessor>();
			processor.onBeatDetected += BeatDetected;
		}
	}

	public void BeatDetected()
	{
		//beatSize = new Vector3(scale.x*(2*Random.value), scale.y*(4*Random.value), scale.z*(2*Random.value));
		//beatSize = Vector3
		mesh.transform.localScale = beatSize;
	}

//	void OnDisable()
//	{
//		AudioProcessor processor = FindObjectOfType<AudioProcessor>();
//		processor.onBeatDetected -= BeatDetected;
//	}
}
