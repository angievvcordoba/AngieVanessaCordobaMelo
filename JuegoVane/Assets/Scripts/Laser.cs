using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Laser : MonoBehaviour
{

    private float velRayoLaser = 23.5f; 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.up * velRayoLaser * Time.deltaTime);

        if (transform.position.y >= 2.705f)
        {
            Destroy(this.gameObject);
        }
    }
}
