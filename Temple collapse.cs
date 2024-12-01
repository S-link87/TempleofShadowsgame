using UnityEngine;

public class TempleCollapse : MonoBehaviour
{
    public GameObject collapsingWalls;
    public float collapseRate = 1f; // How fast the temple collapses

    void Update()
    {
        // Gradually close the walls as the timer runs out
        if (GameManager.instance.timer <= 30f) // Example: when only 30 seconds left
        {
            collapsingWalls.SetActive(true);
            collapsingWalls.transform.Translate(Vector3.down * collapseRate * Time.deltaTime);
        }
    }
}
