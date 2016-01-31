using UnityEngine;
using System.Collections;

public class BeatMaster : MonoBehaviour{

	Vector3 scale = Vector3.zero;
	Vector3 beatSize = Vector3.zero;
	public AudioProcessor processor;

	void Start () 
	{
//		AudioProcessor processor = FindObjectOfType<AudioProcessor>();
//		processor.addAudioCallback(this);

		processor.onBeatDetected += onOnbeatDetected;

		beatSize = new Vector3(scale.x*1.1f, scale.y*4, scale.z*1.1f);

	}
	
	// Update is called once per frame
	void Update () 
	{
		
	}

	public void onOnbeatDetected()
	{
		//Debug.Log("Beat!!!");


		//beatSize = new Vector3(scale.x*(2*Random.value), scale.y*(4*Random.value), scale.z*(2*Random.value));
	}

	public void onSpectrum(float[] spectrum)
	{
		//The spectrum is logarithmically averaged
		//to 12 bands

//		for (int i = 0; i < spectrum.Length; ++i)
//		{
//			Vector3 start = new Vector3(i, 0, 0);
//			Vector3 end = new Vector3(i, spectrum[i], 0);
//			Debug.DrawLine(start, end);
//		}
	}
}

