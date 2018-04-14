using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour {
	float EnemyPositionTimer;

	float timer;
	public GameObject Fire;
	// Use this for initialization
	void Start () {
		timer = Random.Range (-20, 2);
	}
	
	// Update is called once per frame
	void Update () {
		EnemyPositionTimer += Time.deltaTime;
		timer += Time.deltaTime;
		if (timer > 5) {
			Instantiate (Fire, this.transform.position, this.transform.rotation);
			timer = 0; 
		}

		if (timer == 0){
			timer = Random.Range (-20,2);
			timer += Time.deltaTime;
		}

		if(EnemyPositionTimer > 2.5f)  {
			this.transform.position += new Vector3 (0, -0.5f, 0);
			EnemyPositionTimer = 0;
		}
	}
}