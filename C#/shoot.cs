using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class shoot : MonoBehaviour
{

    public Object zidan;
    int counts=0;
	// Use this for initialization

	void Start () {
      
    }
    private void FixedUpdate()
    {
        
            if (Input.GetMouseButton(0) && counts++ > 5)
            {
                Instantiate(zidan, this.transform.position, this.transform.rotation);
            }
            if (counts++ > 5)
            {
                counts = 0;
            }
        
      
    }

    // Update is called once per frame
    void Update () {
		
	}
}
