using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pengz : MonoBehaviour {
    public Object fire;
    private float time0=0;
    // Use this for initialization
    void Start () {
        time0 = Time.time;
        Rigidbody zidan = gameObject.GetComponent<Rigidbody>();
        zidan.velocity = transform.forward*300;
    }
	
	// Update is called once per frame
	void Update () {
		
	}
    private void FixedUpdate()
    {
        if (Time.time - time0 > 3) {
            Instantiate(fire, this.transform.position, this.transform.rotation);
            Destroy(this.gameObject);
        }
        
        
    }

    void OnCollisionEnter(Collision e)
    {
       
        if(e.gameObject.tag.CompareTo("Player")==0)Destroy(e.gameObject);
        
        Instantiate(fire,this.transform.position,this.transform.rotation);
        Destroy(this.gameObject);

    }
}
