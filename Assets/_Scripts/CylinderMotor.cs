using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CylinderMotor : MonoBehaviour { 
    float timecounter = 0;


       public float speed;
      public float width;
     public float height;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timecounter += Time.deltaTime;
        float x = Mathf.Cos(timecounter) * width;
        float y = Mathf.Sin(timecounter) * height;
        float z = 0;

        transform.position = new Vector3(x, y, z);
        
    }
}
