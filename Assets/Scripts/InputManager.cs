using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class InputManager : MonoBehaviour
{

    private string hush1 = "";
    private string hush2 = "";
    private string hush3 = "";
    private string hush4 = "";

    string[] hInputs = new string[4];

    private string hushInput;

    private bool isOpen = false;

    [SerializeField] GameObject input1;
    [SerializeField] GameObject input2;
    [SerializeField] GameObject input3;
    [SerializeField] GameObject input4;

    private bool goodnightBalloon = false;
    private bool goodnightCows = false;
    private bool goodnightBears = false;
    private bool goodnightKittens = false;
    private bool goodnightMittens = false;
    private bool goodnightMouse = false;
    private bool goodnightComb = false;
    private bool goodnightBrush = false;
    private bool goodnightMoon = false;
    private bool goodnightLight = false;
    private bool goodnightClock = false;
    private bool goodnightSock = false;
    private bool goodnightMush = false;
    private bool goodnightHouse = false;
    private bool goodnightStars = false;
    private bool goodnightPhone = false;

    bool[] goodnights = new bool[16];

    // Start is called before the first frame update
    void Start()
    {
        hInputs[0] = hush1;
        hInputs[1] = hush2;
        hInputs[2] = hush3;
        hInputs[3] = hush4;

        goodnights[0] = goodnightBalloon;
        goodnights[1] = goodnightCows;
        goodnights[2] = goodnightBears;
        goodnights[3] = goodnightKittens;
        goodnights[4] = goodnightMittens;
        goodnights[5] = goodnightMouse;
        goodnights[6] = goodnightComb;
        goodnights[7] = goodnightBrush;
        goodnights[8] = goodnightMoon;
        goodnights[9] = goodnightLight;
        goodnights[10] = goodnightClock;
        goodnights[11] = goodnightSock;
        goodnights[12] = goodnightMush;
        goodnights[13] = goodnightHouse;
        goodnights[14] = goodnightStars;
        goodnights[15] = goodnightPhone;

    }

    // Update is called once per frame
    void Update()
    {
        if (CheckHush() && CheckGoodnights())
        {
            isOpen = true;
            SceneManager.LoadScene("WinCutScene1");
        }
    }

    public void inputH1()
    {
        hush1 = input1.GetComponent<TMP_InputField>().text;
        hInputs[0] = hush1;
        inputHush();
    }

    public void inputH2()
    {
        hush2 = input2.GetComponent<TMP_InputField>().text;
        hInputs[1] = hush2;
        inputHush();
    }

    public void inputH3()
    {
        hush3 = input3.GetComponent<TMP_InputField>().text;
        hInputs[2] = hush3;
        inputHush();
    }

    public void inputH4()
    {
        hush4 = input4.GetComponent<TMP_InputField>().text;
        hInputs[3] = hush4;
        inputHush();
    }

    public void inputHush()
    {

        for (int i = 0; i < hInputs.Length; i++)
        {
            if (hInputs[i] == "")
            {
                return;
            }
        }

        hushInput = "";

        for (int i = 0; i < hInputs.Length; i++)
        {
            hushInput += hInputs[i];
        }

        CheckHush();

    }

    private bool CheckHush()
    {
        if (string.Equals(hushInput, "hush"))
        {
            return true;
        } 
        return false;
    }

    private bool CheckGoodnights()
    {
        for (int i = 0; i < goodnights.Length; i++)
        {
            if (goodnights[i] == false)
            {
                return false;
            }
        }
        return true;
    }

    public void GNBalloon ()
    {
        goodnightBalloon = true;
        goodnights[0] = goodnightBalloon;
    }

    public void GNCows()
    {
        goodnightCows = true;
        goodnights[1] = goodnightCows;
    }

    public void GNBears()
    {
        goodnightBears = true;
        goodnights[2] = goodnightBears;
    }

    public void GNKittens()
    {
        goodnightKittens = true;
        goodnights[3] = goodnightKittens;
    }

    public void GNMittens()
    {
        goodnightMittens = true;
        goodnights[4] = goodnightMittens;
    }

    public void GNMouse()
    {
        goodnightMouse = true;
        goodnights[5] = goodnightMouse;
    }

    public void GNComb()
    {
        goodnightComb = true;
        goodnights[6] = goodnightComb;
    }

    public void GNBrush()
    {
        goodnightBrush = true;
        goodnights[7] = goodnightBrush;
    }

    public void GNMoon()
    {
        goodnightMoon = true;
        goodnights[8] = goodnightMoon;
    }

    public void GNLight()
    {
        goodnightLight = true;
        goodnights[9] = goodnightLight;
    }

    public void GNClock()
    {
        goodnightClock = true;
        goodnights[10] = goodnightClock;
    }

    public void GNSock()
    {
        goodnightSock = true;
        goodnights[11] = goodnightSock;
    }

    public void GNMush()
    {
        goodnightMush = true;
        goodnights[12] = goodnightMush;
    }

    public void GNHouse()
    {
        goodnightHouse = true;
        goodnights[13] = goodnightHouse;
    }

    public void GNStars()
    {
        goodnightStars = true;
        goodnights[14] = goodnightStars;
    }

    public void GNPhone()
    {
        goodnightPhone = true;
        goodnights[15] = goodnightPhone;
    }
}
