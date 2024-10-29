using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformScript : MonoBehaviour
{
    public float platformSpeed = 5;
    public float platformDeadZone = -40;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = transform.position + (Vector3.left * platformSpeed) * Time.deltaTime;

        if (transform.position.x < platformDeadZone)
        {
            Debug.Log("Platform Deleted");
            Destroy(gameObject);
        }
    }
}
