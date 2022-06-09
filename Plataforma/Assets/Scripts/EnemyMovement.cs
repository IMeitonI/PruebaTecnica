using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour {
    [SerializeField] Transform pos1, pos2;
    Transform targetTransform, currentPos;
    float realTime;
    [SerializeField] float wantedTime = 2;
    

    void Start() {
        transform.position = pos2.position;
        currentPos = pos2;
        targetTransform = pos1;
    }

    // Update is called once per frame
    void Update() {
       
        Move();

    }
    void Move() {
        
        if (realTime <= wantedTime) {
            transform.position = Vector2.Lerp(currentPos.position, targetTransform.position, realTime / wantedTime);
            realTime += Time.deltaTime;

        } else {
            transform.position = targetTransform.position;
            realTime = 0;
            ChangeDirection();
        }

    }

    void ChangeDirection() {
        if (transform.position == pos1.position) {
            targetTransform = pos2;
            currentPos = pos1;
        } else if (transform.position == pos2.position) {
            targetTransform = pos1;
            currentPos = pos2;
        }
    }

}
