using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemController : MonoBehaviour
{

    [SerializeField] private string objectName;
    [SerializeField] private GameObject panel;

    [SerializeField] private PlayerController player;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit2D hit = Physics2D.GetRayIntersection(ray, Mathf.Infinity);

            if (hit.collider != null && hit.collider.gameObject.name == objectName)
            {

                if (player.canInteract)
                {
                    ChangePanel();
                }

            }

        }
    }

    public void ChangePanel ()
    {
        player.canInteract = (!player.canInteract);

        panel.SetActive(!panel.activeSelf);
    }
}
