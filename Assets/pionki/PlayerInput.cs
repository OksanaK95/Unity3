using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : MonoBehaviour
{ 
    void Update() {
        if(Input.GetKeyDown(KeyCode.Space)) {
         Debug.Log("spacja wcisnieta");
        }
        if(Input.GetKeyDown(KeyCode.UpArrow)) {
            GetComponent<Movementcontroller>().Move(new Vector2Int(0, 1));

        }
        
            if(Input.GetKeyDown(KeyCode.LeftArrow)) {
            GetComponent<Movementcontroller>().Move(new Vector2Int(-1, 0));
        }

        }
    
  
}
