using System;
using System.Threading.Tasks;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoteGen : MonoBehaviour
{
    // Start is called before the first frame update
    async void Start()
    {
		int count = 0;
		// Load prefab object from Resources
		GameObject note_pf0 = Resources.Load<GameObject>("note0"); 
		GameObject note_pf1 = Resources.Load<GameObject>("note1"); 
		GameObject note_pf2 = Resources.Load<GameObject>("note2"); 
		GameObject note_pf3 = Resources.Load<GameObject>("note3"); 
		while(count < 5) {
			count++;
			await Task.Delay(500);
			// Generate object from prefab
			Instantiate(note_pf0); 
			await Task.Delay(500);
			Instantiate(note_pf1); 
			await Task.Delay(500);
			Instantiate(note_pf2);
			await Task.Delay(500);		
			Instantiate(note_pf3); 
		}

    }

}
