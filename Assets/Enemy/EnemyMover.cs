using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMover : MonoBehaviour
{
    [SerializeField]
    List<Waypoint> path = new List<Waypoint>();

    [SerializeField] 
    float waitTime = 1f;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(FollowPath());
    }

    // Update is called once per frame
    void Update()
    {

    }

    IEnumerator FollowPath()
    {
        foreach(var waypoint in path)
        {
            transform.localPosition = waypoint.transform.localPosition;
            yield return new WaitForSeconds(waitTime);
        }
    }
}
