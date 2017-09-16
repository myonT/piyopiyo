using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerScript : MonoBehaviour {

    public int score = 0;
    public Text scoretext;

	// Use this for initialization
	void Start () {
        scoretext.text = "Score : 0";
		
	}
	
	// Update is called once per frame
	void Update () {
        if(Input.GetKeyDown(KeyCode.Space)){
            GetComponent<Rigidbody>().velocity = new Vector3(0,6,0);
            GetComponent<AudioSource>().Play();
        }
		
	}

    private void OnCollisionEnter(Collision collision)
	{
  //      if (collision.CompareTag("Player"))
		//{
		Debug.Log("GameOver");
        SceneManager.LoadScene("GameOver");
		//}
	}

    private void OnTriggerExit(Collider other)
    {
        score++;
        Debug.Log(score);
        scoretext.text = "Score : " + score;
    }
}
