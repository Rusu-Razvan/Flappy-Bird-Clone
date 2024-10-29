using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeMoveScript : MonoBehaviour
{
    public float moveSpeed = 20;
    public float deadZone = -40;
    public float speedY = 2;
    public float distance = 1;
    private float startY;
    public float maxDistance = 2;
    public float minDistance = 0.5f;
    

    // Start is called before the first frame update
    void Start()
    {
        startY = transform.position.y;
        distance = Random.Range(minDistance, maxDistance) * (Random.value > 0.5 ? 1 : -1);
    }

    // Update is called once per frame
    void Update()
    {
        
        transform.position = transform.position + (Vector3.left * moveSpeed) * Time.deltaTime;

        if(transform.position.x < deadZone)
        {
            Debug.Log("Pipe Deleted");
            Destroy(gameObject);
        }

        float newY = startY + (Mathf.Sin(Time.time * speedY) * distance);
        transform.position = new Vector3(transform.position.x, newY, transform.position.z);

    }
    
}
