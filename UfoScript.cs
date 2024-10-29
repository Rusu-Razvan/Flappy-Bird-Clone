using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UfoScript : MonoBehaviour
{
    public Rigidbody2D myRigidbody;
    public float flapStrength;
    public LogicScript logic;
    public bool ufoIsAlive = true;

    // Start is called before the first frame update
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
        Time.timeScale = 1;
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.timeScale == 0) return;

        if (Input.GetKeyDown(KeyCode.Space) == true && ufoIsAlive == true)
        {
            myRigidbody.velocity = Vector2.up * flapStrength;
        }

        if (transform.position.y >= 14.5 || transform.position.y <= -14.5)
        {
            GameOver();
        }
    }
      
        
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.layer == 6)
        GameOver();
    }

   public  void GameOver()
    {
        logic.gameOver();
        ufoIsAlive = false;
    }
}
