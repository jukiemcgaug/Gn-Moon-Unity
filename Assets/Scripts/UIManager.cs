using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UIManager : MonoBehaviour
{

    [SerializeField] private TextMeshProUGUI clueText;
    [SerializeField] private TextMeshProUGUI timeText;

    private float totalTime = 20;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        totalTime -= Time.deltaTime;
        timeText.text = "" + totalTime;
    }

    public void DisplayClue (string message)
    {
        clueText.gameObject.SetActive(true);
        clueText.text = message;

        StartCoroutine(ClearText());

    }

    private IEnumerator ClearText ()
    {
        yield return new WaitForSeconds(2);

        clueText.text = "";
    }
}
