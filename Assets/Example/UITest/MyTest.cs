/*===============================================================
 *Copyright(C) 2017 by    U3DC All rights reserved. 
 *FileName:               #MyTest# 
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
using UnityEngine.UI;
using UniEventDispatcher;

public class MyTest : MonoBehaviour {

	private Button _test_btn;

	void Awake () {
		_test_btn = GameObject.Find ("Button").GetComponent<Button> ();
	}
	
	
	void Start () {
		_test_btn.onClick.AddListener (()=>NotificationCenter.Get().DispatchEvent("TestEvt",0));
	}
	

}
