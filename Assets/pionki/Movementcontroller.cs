using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movementcontroller : MonoBehaviour
{

    public void Move(Vector2Int direction){
        //transform.position += new Vector3(direction.x, 0, direction.y);
        GetComponent<Animator>().Play("moveforward");
    }
    
}
