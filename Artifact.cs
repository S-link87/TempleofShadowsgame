using UnityEngine;

public class Artifact : MonoBehaviour
{
    public string artifactName;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            // Add points or bonuses when collected
            GameManager.instance.CollectArtifact(artifactName);
            Destroy(gameObject); // Destroy artifact after collection
        }
    }
}
