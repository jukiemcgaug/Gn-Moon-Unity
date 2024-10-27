using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

public class ItemController : MonoBehaviour
{

    [SerializeField] private string objectName;
    [SerializeField] private GameObject panel;

    [SerializeField] private PlayerController player;

    private PostProcessVolume ppVolume;

    // Start is called before the first frame update
    void Start()
    {
        ppVolume = Camera.main.gameObject.GetComponent<PostProcessVolume>();
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

        ppVolume.enabled = !ppVolume.enabled;
        panel.SetActive(!panel.activeSelf);
    }
}
