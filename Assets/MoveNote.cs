using System;
using System.Threading.Tasks;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveNote : MonoBehaviour
{
	// Update is called once per frame
	void Update()
	{
		Vector3 pos = transform.position;
		pos.y -= 0.015f; // Move object down
		transform.position = pos; 
	}
	
	void OnTriggerStay(Collider other) {
		if(other.gameObject.CompareTag("NoteJudgeLine")) {
			//If key is pressed
			KeyCode noteKey = KeyCode.D;
			switch(this.gameObject.name){
				case "note0(Clone)":
					noteKey = KeyCode.D;
					break;
				case "note1(Clone)":
					noteKey = KeyCode.F;
					break;
				case "note2(Clone)":
					noteKey = KeyCode.J;
					break;
				case "note3(Clone)":
					noteKey = KeyCode.K;
					break;
			}
			if (Input.GetKey(noteKey)) {
				//Get position of note/line
				Vector3 notePos = this.gameObject.transform.position;
				Vector3 linePos = other.gameObject.transform.position;
				//Calc distance
				float distance = Vector3.Distance(linePos, notePos);
				String disStr = distance.ToString();
				if(distance < 1.5) {
					Debug.Log("Perfect" + disStr);
				} else {
					Debug.Log(disStr);
				}
				
				//Destroy NoteObject
				Destroy(this.gameObject); 
			}
		}
	}
	
	void OnTriggerExit(Collider other) {
		// if get out of JudgeLine
		if(other.gameObject.CompareTag("NoteJudgeLine")) { 
			// Destroy NoteObject
			Destroy(this.gameObject); 
		}
	}
}
