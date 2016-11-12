using UnityEngine;
using System.Collections;

[RequireComponent(typeof(CharacterController))]

public class Grounding : MonoBehaviour {

    private float gravity, jumpLimit, jumpForce;
    private CharacterController cc;
    private Vector3 tempP;


    void Start() {
        cc = GetComponent<CharacterController>();
    }

    void Update() {
        tempP.y = gravity;
        tempP.y += Jump(Input.GetAxis("Vertical"));
        cc.Move(tempP * Time.deltaTime);
    }

    float Move(float mov) {
        return mov;
    }

    float Jump(float jmp) {
        if (jumpLimit > 0){
             jumpLimit-= Time.deltaTime;
            return jmp * jumpForce;
        }
        if (cc.isGrounded) {
            jumpLimit = 2;
            return 0;
        }
    }

}
