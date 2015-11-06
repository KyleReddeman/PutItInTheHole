using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

    // Use this for initialization
    public float speed;
    public Rigidbody2D rb;

    GameObject sun; 

    float x = 0;
    float y = 0;
    bool hasShot = false;
    Vector2 direction = new Vector2();

	void Start () {
	    sun = GameObject.Find("Sun");
       // this.GetComponent<DistanceJoint2D>().anchor.Set(sun.transform.position.x, sun.transform.position.y);
    }

    // Update is called once per frame
    void Update() {
        // transform.Translate(Vector3.up * Time.deltaTime, Space.World);
        if (hasShot == false)
        {
            rb.velocity = new Vector2(-y, x) * speed * Time.deltaTime;
            x = transform.position.x - sun.transform.position.x;
            y = transform.position.y - sun.transform.position.y;
        }
        else
        {
        }
        if (Input.GetKeyDown(KeyCode.Space) this.)
        {

            Destroy(this.GetComponent<DistanceJoint2D>());
            rb.velocity = new Vector2(-y, x) * speed * Time.deltaTime;
            hasShot = true;
        }
        
        

    }
    
}
