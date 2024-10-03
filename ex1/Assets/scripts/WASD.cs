using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WASD : MonoBehaviour
{
    //Variables
    public float speed = 3f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //find the position of the object every frame and make a vector
        Vector2 pos = transform.position;

        //If i press right arrow, move the position to the right
        if (Input.GetKey(KeyCode.RightArrow))
        {
            pos.x += speed * Time.deltaTime;
        }



        //If i press left arrow, move the position to the left
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            pos.x -= speed * Time.deltaTime;
        }

        //If i press up arrow, move the position to the up
        if (Input.GetKey(KeyCode.UpArrow))
        {
            pos.y += speed * Time.deltaTime;
        }

        //If i press down arrow, move the position to the down
        if (Input.GetKey(KeyCode.DownArrow))
        {
            pos.y -= speed * Time.deltaTime;
        }

        //MOVE!
        transform.position = pos;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        GameManager.Instance.StartScene();
    }
}
