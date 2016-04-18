using UnityEngine;
using System.Collections;

public class onlineButton : MonoBehaviour 
{
	public void NextLevelButton(int index)
	{
		Application.LoadLevel(index);
	}

	public void NextLevelButton(string Online_Main)
	{
		Application.LoadLevel(Online_Main);
	}
}