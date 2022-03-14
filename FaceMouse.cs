using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FaceMouse : MonoBehaviour
{
    private void FixedUpdate() {
        Vector3 TargetPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Vector2 direction = new Vector2(TargetPosition.x - transform.position.x, TargetPosition.y - transform.position.y);
        transform.right = direction;    
    }
}
