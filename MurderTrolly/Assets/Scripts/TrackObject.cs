using UnityEngine;

public class TrackObject : MonoBehaviour
{
    [SerializeField] private int track;
    [SerializeField] private bool shouldBeKilled;

    void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Collision began with: " + collision.gameObject.name);
    }
}
