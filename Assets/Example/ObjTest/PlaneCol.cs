using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniEventDispatcher;

public class PlaneCol : MonoBehaviour {

	// Use this for initialization
	void Start () {
		NotificationCenter.Get ().AddEventListener ("ColEvt", OnColEvt);
		Debug.Log ("Regist Event");
	}
	

	void OnColEvt(Notification notf)
	{
		GameObject.Destroy ((GameObject)notf.param);
	}

}
