using UnityEngine;
using System.Collections;

public class soundStone : MonoBehaviour {

	Renderer thisRen;
	public Renderer lEdgeRen;
	public Renderer rEdgeRen;
	float lerpSpeed = 2.5f;
	public Color baseColor;
	public Color beatColor;
	public Material lineMat;
	public Color baseLineColor = Color.gray;
	public Color currentBaseLineColor = Color.gray;


	void Start ()
	{
	
		AudioProcessor processor = FindObjectOfType<AudioProcessor>();
		processor.onBeatDetected += BeatDetected;
		processor.onSpectrumDetected += SpectrumDetected;

		thisRen = GetComponent<Renderer>();
	}
	
	// Update is called once per frame
	void Update () 
	{
		thisRen.material.color = Color.Lerp(thisRen.material.color, baseColor,lerpSpeed*Time.deltaTime);
		lEdgeRen.material.color = thisRen.material.color;
		rEdgeRen.material.color = thisRen.material.color;
		currentBaseLineColor = Color.Lerp(currentBaseLineColor, baseLineColor,lerpSpeed*Time.deltaTime);

		lineMat.SetColor("_EmissionColor",currentBaseLineColor);
	}

	public void BeatDetected()
	{
		//Debug.Log("Beat!!!");
		//audioCube.localScale = beatSize;
		thisRen.material.color = beatColor;
		lEdgeRen.material.color = thisRen.material.color;
		rEdgeRen.material.color = thisRen.material.color;
		currentBaseLineColor = thisRen.material.color;

		//beatSize = new Vector3(scale.x*(2*Random.value), scale.y*(4*Random.value), scale.z*(2*Random.value));
	}

	public void SpectrumDetected(float[] spectrum)
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
