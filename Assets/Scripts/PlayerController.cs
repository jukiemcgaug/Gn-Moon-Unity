using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{

    public int speed;
    public float minPos;
    public float maxPos;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Vector2 min = new Vector2(
            minPos,
            gameObject.transform.position.y
            );

        Vector2 max = new Vector2(
            maxPos,
            gameObject.transform.position.y
            );

        if (Input.GetKey(KeyCode.RightArrow))
        {

            Vector2 newPos = new Vector2(
                gameObject.transform.position.x + speed * Time.deltaTime,
                gameObject.transform.position.y
                );
            if (gameObject.transform.position.x + speed * Time.deltaTime >= maxPos)
            {
                gameObject.transform.position = max;
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
            if (gameObject.transform.position.x - speed * Time.deltaTime <= minPos)
            {
                gameObject.transform.position = min;
            }
            else
            {
                gameObject.transform.position = newPos;
            }
        }
    }
}
