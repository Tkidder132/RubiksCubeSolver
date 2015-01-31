﻿using UnityEngine;
using System.Collections;

public class RubiksCubeSolver : MonoBehaviour
{
	public RubiksCubeController fullCubeController;
	private ArrayList ActionsList = new ArrayList();

	private CubeModel[,,] fullCube;

	public void SolveTopCrossMiddle(CubeModel[,,] fullCubeModel)
	{
		//find the middle white piece and move it to center top
		//it can only be in one of six spots

		CubeModel temp;
		temp = fullCube [1, 1, 0];
		if (temp.GetTopColor ().Equals (Color.white))
		{
			fullCubeController.IncreaseStage();
			return;
		}

		temp = fullCube [1, 1, 2];
		if (temp.GetBottomColor ().Equals (Color.white))
		{
			ActionsList.Add(9);
			ActionsList.Add(9);
			fullCubeController.IncreaseStage();
			return;
		}

		temp = fullCube [1, 0, 1];
		if (temp.GetFrontColor ().Equals (Color.white))
		{
			ActionsList.Add(9);
			fullCubeController.IncreaseStage();
			return;
		}

		temp = fullCube [1, 2, 1];
		if (temp.GetBackColor ().Equals (Color.white))
		{
			ActionsList.Add(8);
			fullCubeController.IncreaseStage();
			return;
		}

		temp = fullCube [0, 1, 1];
		if (temp.GetLeftColor ().Equals (Color.white))
		{
			ActionsList.Add(14);
			fullCubeController.IncreaseStage();
			return;
		}

		temp = fullCube [2, 1, 1];
		if (temp.GetRightColor ().Equals (Color.white))
		{
			ActionsList.Add(15);
			fullCubeController.IncreaseStage();
			return;
		}
	}

	public void SolveTopCross(CubeModel[,,] fullCubeModel)
	{
		//second rotate the rest of the cross sides
		//TODO: SOLVE WHITE/TOP SIDE
	}
	
	public void SolveTopCorners(CubeModel[,,] fullCubeModel)
	{
		//TODO: SOLVE WHITE/TOP SIDE
	}
	
	public void SpinMiddle(CubeModel[,,] fullCubeModel)
	{
		//TODO: SPIN MIDDLE COLORS TO MATCHING FACE
	}
	
	public void SolveMiddleSides(CubeModel[,,] fullCubeModel)
	{
		//TODO: SOLVE MIDDLE SIDES
	}
	
	public void SolveBottomCross(CubeModel[,,] fullCubeModel)
	{
		//TODO: SOLVE YELLOW/BOTTOM CROSS
	}
	
	public void SolveBottomCrossSides(CubeModel[,,] fullCubeModel)
	{
		//TODO: SOLVE BOTTOM CROSS SIDES
	}
	
	public void SolveBottomCorners(CubeModel[,,] fullCubeModel)
	{
		//TODO: PLACE CORNERS IN RIGHT SPOT
	}
	
	public void FinishBottomCorners(CubeModel[,,] fullCubeModel)
	{
		//TODO: SPIN CORNERS TO RIGHT DIRECTION
	}
	
	public void SpinToWin(CubeModel[,,] fullCubeModel)
	{
		//TODO: SPIN COLORS TO MATCH AND FINISH
	}
}
