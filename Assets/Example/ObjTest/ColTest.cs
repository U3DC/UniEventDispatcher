using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniEventDispatcher;

public class ColTest : MonoBehaviour {

	void OnCollisionEnter(Collision collision)
	{
		NotificationCenter.Get ().DispatchEvent ("ColEvt",this.gameObject);
		Debug.Log ("Dispatch Event");
	}

	void OnDestroy()
	{
		NotificationCenter.Get ().RemoveEventListener ("ColEvt");
		Debug.Log ("Remove Event");
	}

}
