using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {
	//変数を宣言
	float speed = 5.0f;
	float sideSpeed = 5.0f;
	public GameObject missile;
	bool haveItem = false;//アイテムを取得しているかのフラグ
	// Use this for initialization
	public GameObject sound;
	void Start () {
		//自分の座標に足し算をする
	
	}
	
	// Update is called once per frame
	void Update () {
		
		if (Input.GetKey ("right") == true) {
			this.transform.position += new Vector3 (sideSpeed * Time.deltaTime, 0, 0);
		}
		if (Input.GetKey ("left") == true) {
			this.transform.position -= new Vector3 (sideSpeed * Time.deltaTime, 0, 0);
		}
		if (Input.GetKeyDown("a")==true){
			if (haveItem == false) {
				Instantiate (missile, this.transform.position+new Vector3 (0, 1, 0), this.transform.rotation);
				Instantiate (sound);
			}
			else{
			Instantiate(missile,this.transform.position+new Vector3 (-1, 1, 0), this.transform.rotation);
			Instantiate(missile,this.transform.position+new Vector3 (1, 1, 0), this.transform.rotation);
		    Instantiate (sound);
			}

		}
		//当たり判定(衝突なし) 
		}
	void OnTriggerEnter(Collider col)
	{
		//触れた相手のtagが"Item"だった時の処理
		if(col.gameObject.tag == "Item")
		{
			haveItem = true;
			Destroy (col.gameObject);
		}
	}
}