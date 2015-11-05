using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

    // Use this for initialization
    public float speed;
    public Rigidbody2D rb;

    float x = 0;
    float y = 0;
    bool hasShot = false;
    Vector2 direction = new Vector2();

	void Start () {
	
	}

    // Update is called once per frame
    void Update() {
        // transform.Translate(Vector3.up * Time.deltaTime, Space.World);
        if (hasShot == false)
        { 
            transform.RotateAround(Vector2.zero, Vector3.forward, speed * Time.deltaTime);
            x = transform.position.x;
            y = transform.position.y;
        }
        else
        {
                transform.Translate(new Vector3(-y, x) * 3 * Time.deltaTime , Space.World);
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            hasShot = true;
        }
        
        

    }
    
}
