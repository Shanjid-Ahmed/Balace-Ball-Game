using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallControlar2 : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

	}
	public float force =1;

	void FixedUpdate()
	{

		 Vector3 dir = Vector3.zero;
        dir.x = Input.acceleration.y;
        dir.z = -Input.acceleration.x;
        if (dir.sqrMagnitude > 1)
            dir.Normalize();
		
		 Vector3 movement = new Vector3 (Input.acceleration.x, 0.0f, -Input.acceleration.z);
		 
         //this.gameObject.GetComponent<Rigidbody>().velocity = dir * force;
		 this.gameObject.GetComponent<Rigidbody>().AddForce(dir * force);

/*		if(vertical>0)
			this.gameObject.GetComponent<Rigidbody>().AddForce(Vector3.right * force);

		if(vertical<0)
			this.gameObject.GetComponent<Rigidbody>().AddForce(Vector3.left * force);

		if(horizontal>0)
			this.gameObject.GetComponent<Rigidbody>().AddForce(Vector3.back * force);

		if(horizontal<0)
			this.gameObject.GetComponent<Rigidbody>().AddForce(Vector3.forward * force);
*/
	}
	public void OnCollisionEnter(){
		this.GetComponent<AudioSource>().Play();
	
	}

}
