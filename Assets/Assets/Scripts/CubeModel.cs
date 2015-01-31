﻿using UnityEngine;
using System.Collections;

public class CubeModel : MonoBehaviour
{
	//front, back, left, right, top, bottom
	public Color[] _faces = new Color[6];

	public RubiksCubeController cubeController;

	public void RotateCube(Vector3 cubeAxis, Vector3 cubeDirection, float cubeTime)
	{
		StartCoroutine(rotateCubeCoroutine(cubeAxis, cubeDirection, cubeTime));
	}

	IEnumerator rotateCubeCoroutine(Vector3 cubeAxis, Vector3 cubeDirection, float cubeTime)
	{
		cubeController.SetRotating (true);
		for (var i = 0; i < 30; i++)
		{
			this.transform.RotateAround (cubeAxis, cubeDirection, 3);
			yield return new WaitForSeconds(.0005f);
		}
		cubeController.SetRotating (false);
		yield return 0;
	}

	public void SetColors(Color[] faces)
	{
		for (var i = 0; i < this._faces.Length; i++)
		{
			this._faces[i] = faces[i];
		}
	}

	public Color[] GetColorsArray()
	{
		return this._faces;
	}

	public bool CheckColors(Color[] faces)
	{
		for (var i = 0; i < this._faces.Length; i++)
		{
			if( this._faces[i] != faces[i] )
			{
				return false;
			}
		}
		return true;
	}
}