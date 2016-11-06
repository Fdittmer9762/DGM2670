using UnityEngine;
using System.Collections;

public class Loops : MonoBehaviour {

    int things;
    bool True = false;
    public string[] alphabet;

    // Use this for initialization
    void Start () {
	    alphabet = new string[26];
	}

    void ForLoop() {
        for (int i = 0; i <= alphabet.Length; i++) {
            print(alphabet[i]);
        }
    }

    void ForEachLoop() {
        foreach (string item in alphabet) {
            print(item);
        }
    }

    void DoWhileLoop() {
            do
            {
                print("rasberrys");

            } while (True == true); //will always run once
    }

	void WhileLoop () {
        while (things > 0)
        {
            Debug.Log("More");
            things--;
        }
        Debug.Log("No More");
    }
}
