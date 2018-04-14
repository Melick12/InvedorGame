using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class missileScript : MonoBehaviour {
	float speed = 5.0f;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () { 
		this.transform.position += new Vector3 (0, speed * Time.deltaTime, 0);
			}
	void OnCollisionEnter(Collision col){
		if(col.gameObject.tag == ("Enemy")) {
			Destroy (this.gameObject);//あたったらMissileがDestroyされる
			Destroy (col.gameObject);//あたったらEnemyがDestoryされる
		}

	}
}
