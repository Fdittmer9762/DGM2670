using UnityEngine;
using System.Collections;

public class SwitchesAndIFStatements : MonoBehaviour {

    bool num;

	void Start () {
        print(IfStatements(num));
        print(SwitchStatement(num));
	}


    //I created the same functions by using an ifstatement and a switch, both have their advantages and drawbacks
    //typically it's bad to have an if statement within and if statement or a series of if statements because it will never test anthing after a statement is true, use for simple choices and comparisons only

    bool IfStatements(bool thing) {
        if (thing != null)
        {
            if (thing == true)
            {
                print("its right");
            }
            if (thing == false) //if it's true it will never reach the code here, it may cause unreachable code
            {
                print("its wrong");
            }
        }
        else {
            print("something's wrong");
        }
        return thing;
    }

    //swithc statements are better for when their are multiple outcomes or options that only need to be compaired once, better for complex problems, it is easily expandable

    bool SwitchStatement(bool things) {
        switch (things) {
            case true:
                print("its right");
                break;
            case false:
                print("its wrong");
                break;
            case null:
                print("something's wrong");
                break;
        }
        return things;
    }
}
