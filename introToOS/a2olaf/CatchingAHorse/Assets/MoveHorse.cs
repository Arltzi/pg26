using UnityEngine;
using System.Collections;

public class MoveHorse : MonoBehaviour {

    public float speed = 1;

    public Transform[] horsePathNodes;
    private int destinationNode = 0;
    private bool navigating = true;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

        if(navigating)
        {
            if (transform.position != horsePathNodes[destinationNode].position)
            {
                transform.position = Vector3.MoveTowards(transform.position, horsePathNodes[destinationNode].position, Time.deltaTime * speed);
                transform.LookAt(horsePathNodes[destinationNode].transform);
            }
            else
            {
                if (destinationNode < horsePathNodes.Length - 1)
                {
                    destinationNode = destinationNode + 1;
                }
                else
                {
                    destinationNode = 0;
                }
            }
        }

	}
}
