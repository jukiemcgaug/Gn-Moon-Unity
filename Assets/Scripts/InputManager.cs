using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

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

    // Start is called before the first frame update
    void Start()
    {
        hInputs[0] = hush1;
        hInputs[1] = hush2;
        hInputs[2] = hush3;
        hInputs[3] = hush4;
    }

    // Update is called once per frame
    void Update()
    {
        
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

        checkHush();

    }

    private void checkHush()
    {
        if (string.Equals(hushInput, "hush"))
        {
            isOpen = true;
        } else
        {
            isOpen = false;
        }
    }
}
