using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UIManager : MonoBehaviour
{

    [SerializeField] private TextMeshProUGUI clueText;
    [SerializeField] private TextMeshProUGUI timeText;

    [SerializeField] private GameObject cowPanel;
    [SerializeField] private TextMeshProUGUI runText;
    [SerializeField] private GameObject cowButton;
    [SerializeField] private GameObject backButton;

    private float seconds = 0;
    private int secondsInt;
    private string secondsString;
    private int minutes = 2;
    private string minutesString;

    private bool timeOut = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (!timeOut)
        {
            Timer();
        }

        if (cowPanel.activeSelf)
        {
            StartCoroutine(RunText());
        }
    }

    public void Timer() 
    {
        secondsInt = (int)(seconds -= Time.deltaTime);
        secondsString = secondsInt.ToString("00");
        minutesString = minutes.ToString("00");

        if (secondsInt <= 0)
        {
            if (minutes == 0)
            {
                timeOut = true;
                timeText.text = "you lose";
                return;
            }
            seconds = 60;
            minutes--;
        }

        timeText.text = minutesString + ":" + secondsString;
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

    private IEnumerator RunText ()
    {
        runText.text = "";
        runText.gameObject.SetActive(true);

        yield return new WaitForSeconds(2);
        runText.text = "r";

        yield return new WaitForSeconds(2);
        runText.text = "ru";

        yield return new WaitForSeconds(2);
        runText.text = "run";

        yield return new WaitForSeconds(2);
        cowButton.SetActive(true);
        backButton.SetActive(true);
    }
}
