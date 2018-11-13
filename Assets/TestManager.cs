using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestManager : MonoBehaviour
{
    public MsgPanelHandler Panel;
    
	void Start () {
        
		Panel.gameObject.SetActive(true);
	    Panel.Title = "系統通知";
	    Panel.Content = "123/456/789";
	    Panel.YesText = "好";
	    Panel.NoText = "不好";
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
