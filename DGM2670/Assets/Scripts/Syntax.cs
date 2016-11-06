using UnityEngine;
using System.Collections;

public class Syntax : MonoBehaviour {

    //syntax is the way that a language is structured in order to be understood
    //scripts work by having lines of code simialar to a sentence, this allows for things to be organized and easily understood
    //in C# the ; is used as a period. it ends statements or lines **** this is a common mistake, always check this first ****

    int thing = 8;

    // . are used to access and define things within another script
    //it is simalar to an address etc:
    //State.City.County.Town.Neighborhood.Street.House.Room.etc
    //ex:

    //{} [] () are used to contain things, each has its own use

    void Start() {
        Debug.Log(transform.position.y);
    }
    

}
