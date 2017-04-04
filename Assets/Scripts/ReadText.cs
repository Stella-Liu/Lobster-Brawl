using UnityEngine;
using System.Collections;

public class ReadText : MonoBehaviour {

    public TextAsset LightSun;

	// Use this for initialization
	void Start () {
	    
	}
	
	// Update is called once per frame
	void Update () {
        
	}

    void Read()
    {
        var linesArr = LightSun.text.Split('\n');
        for (int i = 0; i < linesArr.Length; i++)
        {
            Debug.Log(linesArr[i]);
        }
    }  
}
