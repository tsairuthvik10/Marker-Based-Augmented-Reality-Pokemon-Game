using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class pokemon2 : MonoBehaviour {
	public Button attackbutton2;
	public GameObject fire;
		public float totalhp2=100;
	public Scrollbar Healthbar1;
	// Use this for initialization
	void Start () {
		attackbutton2.onClick.AddListener (attackbutton2down);
		fire.transform.FindChild ("Glow").gameObject.SetActive (false);
		fire.transform.gameObject.SetActive (false);
	}
	
	IEnumerator Wait (){
		fire.transform.FindChild ("Glow").gameObject.SetActive (true);
		fire.transform.gameObject.SetActive (true);
		yield return new WaitForSeconds (2);
		fire.transform.FindChild ("Glow").gameObject.SetActive (false);
		fire.transform.gameObject.SetActive (false);
	}
	
	void attackbutton2down (){
		StartCoroutine (Wait ());
		
		
	}
	
		public void Damage(float value)
	{
		totalhp2 -= value;
		Healthbar1.size = totalhp2/ 100f;
	}
	// Update is called once per frame
	void Update () {
		
	}
}
