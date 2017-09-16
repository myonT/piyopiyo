using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallCriateScript : MonoBehaviour {
    public GameObject wall;
    float timer = 0f;
    int interval = 3;

	// Use this for initialization
	void Start () {
		Instantiate(wall, transform.position, transform.rotation);
	}
	
	// Update is called once per frame
	void Update () {
        timer += Time.deltaTime;
        if(timer >= interval){
            transform.position = new Vector3(0, Random.Range(-2.5f, 2.5f), 6);//readonly
            Instantiate(wall,transform.position,transform.rotation);
            timer = 0;
        }
		
	}
}
