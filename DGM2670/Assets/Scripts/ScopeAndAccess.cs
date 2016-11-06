using UnityEngine;
using System.Collections;

public class ScopeAndAccess : MonoBehaviour {//current class ScopeAndAccess is derived form MonoBehaviour, will get into later

    int b, c;

    //the scope of a class is defined by {} , anything contained within a set of {} is {wihtin} the scope of the {}

    int ScopeDemo(int x, int y) { //the function scope demo is contained within the class ScopeAndAccess
        int z = x * y; // variables like int x, y, and z are contained within and unique to the function ScopeDemo
        return z;
    } //because vars x, y, and z are contained within scope demo they may only be accessed from within the function



    void PsudoStart () { //custom class because start can;t be used more than once per script
        ScopeDemo(b,c);//because scope demo start and int b and c are all contained within the same calls they can be accessed and used easily
	}

    //this is true, unless we use access modifyers to set the accessablity of a component of the script
    //ex:

    int privateByDefault; //unless specified a var is defaulted to private
    private int privatetInt; //private ints are only accessable from within the containing type, {within the same brackets{this would also be accessable}}
    public int publicInt;//the most promiscuous of all access modifiers, can be accessed from anywhere
    protected int protInt;// like private, but may also be access by classes derived from current class, ex: ScopeAndAccess class is derived from monobehaviour and therefor we can access protected thnigs within monobehaciour
    internal int internalInt;// internal may only be access from the current instance of the class and is unique to that instance
    protected internal int proIntInt;//a combination of internal and protected, Access is limited to the current assembly or types derived from the containing class

    private int ScopeDemoToo(int x, int y)//because ints x, y , and z are all witin the scope of ScopeDemoToo, it doesn't cause any conflicts with the xyand z of ScopeDemo function
    { 
        int z = x * y; 
        return z;
    }

    void AnotherFalseStart() {
        ScopeDemo(proIntInt, internalInt);
        ScopeDemoToo(c, publicInt); //using z would not work because z is internal to the function being called, unique to the instance of the funciton, see below
    }

    //in order to access something from another class first the calss must be public or internal, they default to public, lets use some functions and vars from another script

    void Start() {
        //first we need to make an instance of the class within class 
        AccessDemo AccessingStuff = new AccessDemo();
        //then we can use it
        AccessingStuff.Subtract(AccessingStuff.stuff, AccessingStuff.things); //notice that to access is within instance of the accessdemo class Accessing stuff and can only be access from within the instance
    }

    //PS for readability orginaize your scripts in a readable way, it works, but what ive done with these scripts will shurly earn me a place in the ninth circle of hell, don't be a dick 

}

public class AccessDemo : MonoBehaviour { //doing this for the lesson and easy readability, works, but would'nt recomend for object orientate programming
    public int stuff;
    public int things;

    private string secretBox = "a silly string"; //its a secret

    public int Subtract(int a, int b) {
        return a -= b;
    }

    private int Div(int a, int b) //div cant be access from within the script
    {
        return a /=b;
    }

    private void OpenBox() {
        print("its only " + secretBox ); //little does he know that by pulliing the secret string to reveal a secret compartment of the secret box that contains an embarising photo of spongebob athe anual christmas party
    }
}
