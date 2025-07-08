using UnityEngine;

public class PathFollower : MonoBehaviour
{
    public Transform[] waypoints;
    public float speed = 1.5f;
    public float stopDistance = 0.1f;

    private int currentIndex = 0;

    void Update()
    {
        if (waypoints.Length == 0) return;

        Transform target = waypoints[currentIndex];
        Vector3 direction = target.position - transform.position;

        if (direction.magnitude <= stopDistance)
        {
            currentIndex++;
            if (currentIndex >= waypoints.Length)
            {
                enabled = false; // Fine percorso
                return;
            }
            target = waypoints[currentIndex];
        }

        // Movimento fluido verso il prossimo punto
        transform.position += direction.normalized * speed * Time.deltaTime;
        transform.LookAt(target.position);
    }
}
