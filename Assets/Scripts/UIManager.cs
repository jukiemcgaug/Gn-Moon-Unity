using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{

    [SerializeField] private TextMeshProUGUI clueText;
    [SerializeField] private TextMeshProUGUI timeText;

    [SerializeField] private GameObject cowPanel;
    [SerializeField] private TextMeshProUGUI runText;
    [SerializeField] private GameObject cowButton;
    [SerializeField] private GameObject backButtonCow;

    [SerializeField] private GameObject bearPanel;
    [SerializeField] private TextMeshProUGUI awakeText;
    [SerializeField] private GameObject bearButton;
    [SerializeField] private GameObject backButtonBear;

    private float seconds = 0;
    private int secondsInt;
    private string secondsString;
    private int minutes = 2;
    private string minutesString;

    private bool timeOut = false;
    private bool paused = false;

    [SerializeField] private PlayerController player;
    [SerializeField] private PostProcessVolume ppvolume;
    [SerializeField] private GameObject pausePanel;

    [SerializeField] private TextMeshProUGUI text41;
    [SerializeField] private TextMeshProUGUI text42;
    [SerializeField] private TextMeshProUGUI text31;
    [SerializeField] private TextMeshProUGUI text32;
    [SerializeField] private TextMeshProUGUI text51;
    [SerializeField] private TextMeshProUGUI text52;
    [SerializeField] private TextMeshProUGUI text53;
    [SerializeField] private TextMeshProUGUI text71;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (!timeOut && !paused)
        {
            Timer();
        }

        if (cowPanel.activeSelf)
        {
            StartCoroutine(RunText());
        }

        if (bearPanel.activeSelf)
        {
            StartCoroutine(AwakeText());
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
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 5);
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

    public void show41()
    {
        text41.gameObject.SetActive(true);
    }

    public void show42()
    {
        text42.gameObject.SetActive(true);
    }

    public void show31()
    {
        text31.gameObject.SetActive(true);
    }

    public void show32()
    {
        text32.gameObject.SetActive(true);
    }

    public void show51()
    {
        text51.gameObject.SetActive(true);
    }

    public void show52()
    {
        text52.gameObject.SetActive(true);
    }

    public void show53()
    {
        text53.gameObject.SetActive(true);
    }

    public void show71()
    {
        text71.gameObject.SetActive(true);
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
        backButtonCow.SetActive(true);
    }

    private IEnumerator AwakeText()
    {
        awakeText.text = "";
        awakeText.gameObject.SetActive(true);

        yield return new WaitForSeconds(1);
        awakeText.text = "s";

        yield return new WaitForSeconds(1);
        awakeText.text = "st";

        yield return new WaitForSeconds(1);
        awakeText.text = "sta";

        yield return new WaitForSeconds(1);
        awakeText.text = "stay";

        yield return new WaitForSeconds(1);
        awakeText.text = "stay a";

        yield return new WaitForSeconds(1);
        awakeText.text = "stay aw";

        yield return new WaitForSeconds(1);
        awakeText.text = "stay awa";

        yield return new WaitForSeconds(1);
        awakeText.text = "stay awak";

        yield return new WaitForSeconds(1);
        awakeText.text = "stay awake";

        yield return new WaitForSeconds(1);
        bearButton.SetActive(true);
        backButtonBear.SetActive(true);
    }

    public void pasue()
    {
        paused = !paused;

        player.canInteract = (!player.canInteract);
        ppvolume.enabled = !ppvolume.enabled;
        pausePanel.SetActive(!pausePanel.activeSelf);
    }

    public void restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
