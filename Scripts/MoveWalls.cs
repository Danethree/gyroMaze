using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveWalls : MonoBehaviour
{
    // Start is called before the first frame update

    public Transform[] wayPoints;
    public Transform wall;
    private Vector3 target;
    public float moveWallSpeed;

    void Start()
    {
        wall.position = wayPoints[0].position;
        target = wayPoints[1].position;
    }

    // Update is called once per frame
    void Update()
    {
        WallMovement();
    }

    public void WallMovement()
    {
        wall.position = Vector3.MoveTowards(wall.position, target, moveWallSpeed * Time.deltaTime);
        if (wall.position == target)
        {
            if (target == wayPoints[0].position)
            {

                target = wayPoints[1].position;

            }
            else if (target == wayPoints[1].position)
            {

                target = wayPoints[0].position;
            }
        }

     }
}
