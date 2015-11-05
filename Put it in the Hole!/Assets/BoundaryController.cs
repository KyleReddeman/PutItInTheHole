using UnityEngine;
using System.Collections;

public class BoundaryController : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    void OnTriggerExit2D(Collider2D other)
    {
        Application.LoadLevel("level_1");
    }
}
