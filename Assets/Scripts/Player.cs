using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour {

    public float jumpForce = 10f;
    public Rigidbody2D rb;

    public string currentColor;
    public SpriteRenderer sr;

    public Color colorCyan,colorYellow,colorMagenta,colorPink;
    private void Start()
    {
        rb.gravityScale=0; 
        SetRandomColor();
    }

    // Update is called once per frame
    void Update () {
        if (Input.GetButtonDown("Jump") || Input.GetMouseButtonDown(0))
        {
            rb.gravityScale = 3;
            rb.velocity = Vector2.up * jumpForce;
        }
	}

    void SetRandomColor()
    {
        int index = Random.Range(0, 4);
        switch(index)
        {
            case 0:
                currentColor = "Cyan";
                sr.color = colorCyan;
                break;
            case 1:
                currentColor = "Yellow";
                sr.color = colorYellow;
                break;
            case 2:
                currentColor = "Magenta";
                sr.color = colorMagenta;
                break;
            case 3:
                currentColor = "Pink";
                sr.color = colorPink;
                break;
        }
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag=="ColorChanger")
        {
            SetRandomColor();
            Destroy(collision.gameObject);
            return;
        }
        
        if(collision.tag!=currentColor)
        {
            Debug.Log("Game Over");
            //Handheld.Vibrate();
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            
        }
    }
}
