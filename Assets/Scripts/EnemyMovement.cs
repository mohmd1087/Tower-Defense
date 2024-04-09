using UnityEngine;
using System.Collections;
using UnityEngine.AI;

[RequireComponent(typeof(Enemy))]
public class EnemyMovement : MonoBehaviour {

    private Transform _target;
    private int wavepointIndex = 0;

    private Enemy _enemy;
    // private NavMeshAgent _navAgent;

    void Start()
    {
        _enemy = GetComponent<Enemy>();

        _target = waypoints.points[0];
        // _navAgent = GetComponent<NavMeshAgent>();
        // _navAgent.SetDestination(_target.position);
    }

    void Update()
    {
        Vector3 dir = _target.position - transform.position;
        transform.Translate(dir.normalized * _enemy.speed * Time.deltaTime, Space.World);

        if (Vector3.Distance(transform.position, _target.position) <= 0.4f)
        {
            GetNextWaypoint();
        }
        
        _enemy.speed = _enemy.startSpeed;
        // if (Vector3.Distance(transform.position, _target.position) <= 0.4f)
        // {
        //     GetNextWaypoint();
        // }
        //
        // _navAgent.speed = _enemy.startSpeed;
    }

    void GetNextWaypoint()
    {
        if (wavepointIndex >= waypoints.points.Length - 1)
        {
            EndPath();
            return;
        }

        wavepointIndex++;
        _target = waypoints.points[wavepointIndex];
        // _navAgent.SetDestination(_target.position);
    }

    void EndPath()
    {
        PlayerStats.Lives--;
        WaveSpawner.EnemiesAlive--;
        Destroy(gameObject);
    }

}