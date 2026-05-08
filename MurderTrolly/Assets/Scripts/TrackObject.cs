using UnityEngine;

public class TrackObject : MonoBehaviour
{
    [SerializeField] private int track;
    [SerializeField] private bool shouldBeKilled;
    [SerializeField] private GameObject gameManager;

    void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Collision began with: " + collision.gameObject.name);
        if (shouldBeKilled)
        {
            Debug.Log("Object should be killed. Destroying: " + collision.gameObject.name);
            Destroy(this.gameObject);
        }
    }
}
