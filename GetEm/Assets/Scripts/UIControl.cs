﻿using UnityEngine;
using System.Collections;

public class UIControl : MonoBehaviour {


	public void ChangeScence(string sceneName){
		Application.LoadLevel (sceneName);
	}
	

}
