using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour {
    private int max = 1000;
    private int min = 1;
    private int guess = 500;
    // Use this for initialization
    void Start ()
    {
        Debug.Log("Welcome to Number Wizard");
        Debug.Log("Please Pick a Number: ");
        Debug.Log("The Highest Number you can Pick is " + max);
        Debug.Log("The Lowest Number you can Pick is "+min);
        Debug.Log("Tell me if you number is Higher or Lower then 500");
        Debug.Log("Push Up = higher, Push Down = lower , Push Enter = correct!");

    }
	
	// Update is called once per frame
	void Update ()
    {
        //player input API
        /*https://docs.unity3d.com/ScriptReference/KeyCode.UpArrow.html*/
        //Detect when the up arrow key is pressed down
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            Debug.Log("Up Arrow key was pressed.");
            min = guess;
            guess = (max + min) / 2;
            Debug.Log(guess);
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            Debug.Log("Down Arrow key was pressed.");
            max = guess;
            guess = (max + min) / 2;
            Debug.Log(guess);
        }
        else if (Input.GetKeyDown(KeyCode.Return))
        {
            Debug.Log("Enter key was pressed.");
            Debug.Log("Your Number is : " + guess);
        }
        else if (Input.GetKeyDown(KeyCode.KeypadEnter))
        {
            Debug.Log("\"Other\" Enter key was pressed.");
        }
    }
}
