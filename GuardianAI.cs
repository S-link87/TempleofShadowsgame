using UnityEngine;

public class GuardianAI : MonoBehaviour
{
    public Transform player;
    public float speed = 4f;

    void Update()
    {
        if (player != null)
        {
            Vector3 direction = player.position - transform.position;
            transform.Translate(direction.normalized * speed * Time.deltaTime);
        }
    }
}
