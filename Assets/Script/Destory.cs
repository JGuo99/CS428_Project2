using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destory : MonoBehaviour
{
   	public float timeLeft = 15.0f; // seconds
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (timeLeft > 0){
            timeLeft -= Time.deltaTime;
            if (timeLeft <= 0) {
                Destroy(this.gameObject);
      	}
      }
    }
}