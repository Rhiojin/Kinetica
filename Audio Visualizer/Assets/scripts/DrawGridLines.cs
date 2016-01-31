using UnityEngine;
using System.Collections;

public class DrawGridLines  : MonoBehaviour {

	public Color gridColor = Color.white;
	public float gridSpacingX = 0.5f;
	public float gridSpacingY = 0.5f;

	public int blocksWide =32;
	public int blocksHigh = 24;

	public Vector3 gridCentre;


	Vector3 GetLowerLeftDrawPoint(int squaresWide , int squaresHigh ) // returns the starting point at the lower left point
	{
		float xPos =(float)( -((squaresWide * gridSpacingX)/2) + gridCentre.x);
		float yPos = (float)(-((squaresHigh * gridSpacingY)/2) + gridCentre.y);
		return new Vector3 (xPos, yPos, 0f);
	}


	void OnDrawGizmos () 
	{
		Gizmos.color = gridColor;
		Vector3 lowerLeftStartPoint = GetLowerLeftDrawPoint(blocksWide, blocksHigh);

		float lineLength = blocksWide * gridSpacingX;
		for( int xLine = 0 ; xLine <= blocksHigh ; xLine++)
		{
			Vector3 vFrom =  lowerLeftStartPoint + new Vector3(0f,0f,(float)(xLine * gridSpacingY));
			Vector3 vTo = vFrom + new Vector3(lineLength, 0f, 0f);
			Gizmos.DrawLine (vFrom, vTo);
		}

		// draw the vertical lines now
		lineLength = blocksHigh * gridSpacingY;
		for (int yLine = 0; yLine <= blocksWide ; yLine++)
		{
			Vector3 hFrom = lowerLeftStartPoint + new Vector3((float)(yLine * gridSpacingX), 0f, 0f);
			Vector3 hTo = hFrom + new Vector3(0f, 0, lineLength);
			Gizmos.DrawLine (hFrom, hTo);
		}


	}
}
