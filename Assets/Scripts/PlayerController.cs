using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{

    public int speed;
    public float minXPos;
    public float maxXPos;
    public float minYPos;
    public float maxYPos;

    public bool canInteract = true;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Vector2 minX = new Vector2(
            minXPos,
            gameObject.transform.position.y
            );

        Vector2 maxX = new Vector2(
            maxXPos,
            gameObject.transform.position.y
            );

        Vector2 minY = new Vector2(
            gameObject.transform.position.x,
            minYPos
            );

        Vector2 maxY = new Vector2(
            gameObject.transform.position.x,
            maxYPos
            );

        if (canInteract) { 
            if (Input.GetKey(KeyCode.RightArrow))
            {
                Vector2 newPos = new Vector2(
                    gameObject.transform.position.x + speed * Time.deltaTime,
                    gameObject.transform.position.y
                    );
                if (gameObject.transform.position.x + speed * Time.deltaTime >= maxXPos)
                {
                    gameObject.transform.position = maxX;
                }
                else
                {
                    gameObject.transform.position = newPos;
                }

            }
            if (Input.GetKey(KeyCode.LeftArrow))
            {
                Vector2 newPos = new Vector2(
                    gameObject.transform.position.x - speed * Time.deltaTime,
                    gameObject.transform.position.y
                    );
                if (gameObject.transform.position.x - speed * Time.deltaTime <= minXPos)
                {
                    gameObject.transform.position = minX;
                }
                else
                {
                    gameObject.transform.position = newPos;
                }
            }
            if (Input.GetKey(KeyCode.DownArrow))
            {
                Vector2 newPos = new Vector2(
                    gameObject.transform.position.x,
                    gameObject.transform.position.y - speed * Time.deltaTime
                    );
                if (gameObject.transform.position.y - speed * Time.deltaTime <= minYPos)
                {
                    gameObject.transform.position = minY;
                }
                else
                {
                    gameObject.transform.position = newPos;
                }
            }
            if (Input.GetKey(KeyCode.UpArrow))
            {
                Vector2 newPos = new Vector2(
                    gameObject.transform.position.x,
                    gameObject.transform.position.y + speed * Time.deltaTime
                    );
                if (gameObject.transform.position.y + speed * Time.deltaTime >= maxYPos)
                {
                    gameObject.transform.position = maxY;
                }
                else
                {
                    gameObject.transform.position = newPos;
                }
            }
        }
    }
}
