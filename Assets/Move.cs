using UnityEngine;

public class Move : MonoBehaviour {

    public GameObject goal;
    private Vector3 direction;
    public float speed = 2f;
    void Start()
    {
        
    }

    private void Update() {
        direction = goal.transform.position - this.transform.position;
        if (direction.magnitude >= 3)
        {
            Vector3 velocity = direction.normalized * speed * Time.deltaTime;
            this.transform.LookAt(goal.transform.position);
            this.transform.position += velocity;
        }
    }
}
