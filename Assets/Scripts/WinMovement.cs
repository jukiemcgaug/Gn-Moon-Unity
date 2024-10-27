using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinMovement : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        gameObject.transform.position = new Vector2(InputManager.finalX, InputManager.finalY);
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 first = new Vector2(gameObject.transform.position.x, (float)-14.5);
        transform.position = Vector2.Lerp(transform.position, first, Time.deltaTime);

        StartCoroutine(Wait());
        
    }

    private IEnumerator Wait()
    {
        yield return new WaitForSeconds(2);

        Vector2 second = new Vector2((float)-41, gameObject.transform.position.y);
        transform.position = Vector2.Lerp(transform.position, second, Time.deltaTime);
    }
}
