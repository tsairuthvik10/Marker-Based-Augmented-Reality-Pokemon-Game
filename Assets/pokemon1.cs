using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class pokemon1 : MonoBehaviour {
	public Button attackbutton1;
	public GameObject hose;
	public float totalhp1=100;
	public Scrollbar Healthbar;
	
	// Use this for initialization
	void Start () {
		attackbutton1.onClick.AddListener (attackbutton1down);
		hose.transform.FindChild ("Glow").gameObject.SetActive (false);
		hose.transform.gameObject.SetActive (false);
	}
	
	IEnumerator Wait (){
		hose.transform.FindChild ("Glow").gameObject.SetActive (true);
		hose.transform.gameObject.SetActive (true);
		yield return new WaitForSeconds (2);
		hose.transform.FindChild ("Glow").gameObject.SetActive (false);
		hose.transform.gameObject.SetActive (false);
	}
	
	void attackbutton1down (){
		StartCoroutine (Wait ());
		
		
	}
	
	public void Damage(float value)
	{
		totalhp1 -= value;
		Healthbar.size = totalhp1/ 100f;
	}
	// Update is called once per frame
	void Update () {
		
	}
}
