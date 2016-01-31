using UnityEngine;
using System.Collections;

public class analyzer : MonoBehaviour {

	public AudioClip song;
	int songSampleLength;
	float[] songData;

	void Start () 
	{
		songSampleLength = song.samples;
		songData = new float[songSampleLength];
		song.GetData(songData, 0);
		print(songSampleLength);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
