using UnityEngine;
using System.Collections;

public class ReadSong : MonoBehaviour {

    public AudioSource audio1;

	// Use this for initialization
	void Start () {
        audio1 = GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {
        audio1.Play();
        Debug.Log(audio1.time);
    }
}
