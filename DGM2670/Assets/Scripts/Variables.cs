using UnityEngine;
using System.Collections;

public class Variables : MonoBehaviour {


    //there are several types of variables, in C# each script, or instance of a script, creates an instance of the value type
    //the variable is the data stored within the data type

    //ex: 
    //valueType variable; 

    //variables are not limited to numbers, bools and  are also variables
    //ex:
    int myInt; //holds a whole number 1,2,3,etc
    float myFloat; //holds a number with dec 1.025, 2.58, -52.125, etc
    double myDouble; //simailar to double
    bool myBool;// holds yes or no, on or off, true or false (set using true or false)
    string myString;// holds a alphanumeric value, words and numbers adu2@0s!a9&30, etc

    //access modifiers proceed the value type and determine how and if the variable can be accessed or modified
    public int publicFloat;
    private int privateFloat;
    protected int protectedFloat;
    [HideInInspector] public int hiddenPublicInt;
    public static int globalInt;
    //etc...

    //you can then use variables is a few different ways:

    public int intOne, intTwo, result; //defined in the inspector

    void Start() { //unique to unity runs on start up
        intOne = 5; //you can set their value
        result = AddingThings(intOne,intTwo);//you could set its value by feeding it through a function
        Debug.Log(result);//debug.log takes whatever var that is fed into it and displays it in the inspector
        //or
        Debug.Log(AddingThings(intOne, intTwo));//you could feed the results of one functions directly into another to shorten things
        if (result >= 0){ //it can be used to make a choice or comparison
            print("It's a Pos number!!"); //print is another form of Debug.Log unique to unity
        }
        else {//if first is false, it chooses else
            print("It's negitive!");
        }
    }

    int AddingThings(int a, int b) { //function takes arguments and 
        return a += b; //does something to them; adds things
    }

}
