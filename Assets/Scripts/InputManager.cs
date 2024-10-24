using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class InputManager : MonoBehaviour
{

    private string hush1;
    private string hush2;
    private string hush3;
    private string hush4;

    private string hushInput;

    [SerializeField] GameObject input1;
    [SerializeField] GameObject input2;
    [SerializeField] GameObject input3;
    [SerializeField] GameObject input4;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void inputH1()
    {
        hush1 = input1.GetComponent<TMP_InputField>().text;
        inputHush();
    }

    public void inputH2()
    {
        hush2 = input2.GetComponent<TMP_InputField>().text;
        inputHush();
    }

    public void inputH3()
    {
        hush3 = input3.GetComponent<TMP_InputField>().text;
        inputHush();
    }

    public void inputH4()
    {
        hush4 = input4.GetComponent<TMP_InputField>().text;
        inputHush();
    }

    public void inputHush()
    {
        hushInput = "" + hush1 + hush2 + hush3 + hush4;
        Debug.Log(hushInput);
    }
}
