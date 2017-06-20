/*===============================================================
 *Copyright(C) 2017 by    U3DC All rights reserved. 
 *FileName:               Reciver
 *Author:                 Mark.II
 *Version:                1.0 
 *UnityVersion：          5.6.1p3
 *Date:                   2017.6.20
 *Description:    
 *History: 
================================================================*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniEventDispatcher;

public class Reciver : MonoBehaviour {

	void Awake () {
		
	}
	
	
	void Start () {
		NotificationCenter.Get ().AddEventListener ("TestEvt",OnCallBackFunc);
	}
	
	
	void Update () {
		
	}


	void OnCallBackFunc(Notification notif)
	{
		Debug.Log (notif.param);
	}
}
