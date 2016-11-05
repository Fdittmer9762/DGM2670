using UnityEngine;
using System.Collections;

public class Functions : MonoBehaviour {

    public string stringA, stringB, stringNull;
    public int intA, intB;

	//functions are used to call or use different variables
	void Awake () { //awake and start are functions that runs automatally, most functions must be called by scripts that run automatically
	    
        
        //when a function is left empty it does nothing
        //they expand, so you can put as much into a single function as you need


	}

    //to create a function you need several things
    //returnType ScriptName(argument or variables you want the function to use) {all the insides}
    void CustomFunctionExample() {
        //arguments and functionality of function; things you want the script to do
    }


    //method overloading is a way to add extra functionality to a sctipt
    //you can have several functions of the same name that take different paremeters
    //when called the correct script will be called based on the arguments passed into it
    int Add(int a, int b) { //the name of the function is proceded by the kind of arguments that can be fed into it and what it will return
        return a += b;
    }

    float Add(float a, float b) { //everything within par will be fed into the function to return a value
        return a += b;
    }

    string Add(string a, string b) {
        return a += b;
    }

    void PrintNothing()//void returns nothing
    {
        stringNull = "Nothing";// although it returns nothing you can still use it to alter values above it
        print(stringNull);
    }

    void Start() {
        Add(stringA,stringB); //this is how you'd call a funciton
        Debug.Log(Add(intA, intB));//you can feed the results of a function directly into another
        PrintNothing();//when calling a void function you don't have to, or rather can't, feed argument or values into it
    }

    void Update() {
        //update is called every frame, avoid using
    }
}
