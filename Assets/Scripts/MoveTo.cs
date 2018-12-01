using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveTo : MonoBehaviour {

    //Move to this transform
    public Transform movePosition;

    private void Update()
    {
        transform.position = new Vector3(movePosition.position.x, transform.position.y, transform.position.z);
    }

}
