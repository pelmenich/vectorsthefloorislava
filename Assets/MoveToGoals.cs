using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveToGoals : MonoBehaviour
{
    public GameObject goal1;
    public GameObject goal2;
    private Vector3 direction;
    public float speed = 1f;
    private bool whatGoal = true;
    void Start()
    {
        
    }

    private void Update()
    {
        GameObject goal = whatGoal ? goal1 : goal2;
        direction = goal.transform.position - this.transform.position; 
        if (direction.magnitude >= 2)
        {
            Vector3 velocity = direction.normalized * speed * Time.deltaTime;
            this.transform.LookAt(goal.transform.position);
            this.transform.position += velocity;
        }
        else whatGoal = !whatGoal;
    }
}
