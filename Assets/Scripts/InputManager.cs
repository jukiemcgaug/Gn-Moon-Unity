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

    private string phoneInput = "";

    [SerializeField] GameObject input1;
    [SerializeField] GameObject input2;
    [SerializeField] GameObject input3;
    [SerializeField] GameObject input4;

    [SerializeField] PlayerController player;
    public static float finalX;
    public static float finalY;

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

        for (int i = 0; i < goodnights.Length; i++)
        {
            goodnights[i] = false;
        }

    }

    // Update is called once per frame
    void Update()
    {
        if (inputHush() && CheckPhone() && CheckGoodnights())
        {
            finalX = player.transform.position.x;
            finalY = player.transform.position.y;
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex +1);
        }

    }

    public void press0()
    {
        phoneInput += "0";
    }

    public void press1()
    {
        phoneInput += "1";
    }

    public void press2()
    {
        phoneInput += "2";
    }

    public void press3()
    {
        phoneInput += "3";
    }

    public void press4()
    {
        phoneInput += "4";
    }

    public void press5()
    {
        phoneInput += "5";
    }

    public void press6()
    {
        phoneInput += "6";
    }

    public void press7()
    {
        phoneInput += "7";
    }

    public void press8()
    {
        phoneInput += "8";
    }

    public void press9()
    {
        phoneInput += "9";
    }

    public void pressClear()
    {
        phoneInput = "";
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

    public bool inputHush()
    {

        for (int i = 0; i < hInputs.Length; i++)
        {
            if (hInputs[i] == "")
            {
                return false; ;
            }
        }

        hushInput = "";

        for (int i = 0; i < hInputs.Length; i++)
        {
            hushInput += hInputs[i];
        }

        Debug.Log("going to check");
        return CheckHush();

    }

    private bool CheckHush()
    {
        if (string.Equals(hushInput, "hush"))
        {
            Debug.Log("checked true");
            return true;
        }
        Debug.Log("checked false");
        return false;
    }

    private bool CheckGoodnights()
    {
        for (int i = 0; i < goodnights.Length; i++)
        {
            if (goodnights[i] == false)
            {
                Debug.Log("a goodnight is false: " + i);
                return false;
            }
        }
        Debug.Log("goodnights true");
        return true;
    }

    private bool CheckPhone()
    {
        if (string.Equals(phoneInput, "44335557"))
        {
            Debug.Log("checked phone true");
            return true;
        }
        Debug.Log("checked phone false");
        return false;
    }

    public void GNBalloon ()
    {
        goodnights[0] = true;
    }

    public void GNCows()
    {
        goodnights[1] = true;
    }

    public void GNBears()
    {
        goodnights[2] = true;
    }

    public void GNKittens()
    {
        goodnights[3] = true;
    }

    public void GNMittens()
    {
        goodnights[4] = true;
    }

    public void GNMouse()
    {
        goodnights[5] = true;
    }

    public void GNComb()
    {
        goodnights[6] = true;
    }

    public void GNBrush()
    {
        goodnights[7] = true;
    }

    public void GNMoon()
    {
        goodnights[8] = true;
    }

    public void GNLight()
    {
        goodnights[9] = true;
    }

    public void GNClock()
    {
        goodnights[10] = true;
    }

    public void GNSock()
    {
        goodnights[11] = true;
    }

    public void GNMush()
    {
        goodnights[12] = true;
    }

    public void GNHouse()
    {
        goodnights[13] = true;
    }

    public void GNStars()
    {
        goodnights[14] = true;
    }

    public void GNPhone()
    {
        goodnights[15] = true;
    }
}
