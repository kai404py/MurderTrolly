using UnityEngine;

public class TrackObject : MonoBehaviour
{
    [SerializeField] private int track;
    [SerializeField] private GameObject Hud;

    public string name;
    public string[] passiveKillComments;
    public string[] activeKillComments;
    public bool isActiveKill = false;

    private bool hasTriggered;

    void OnCollisionEnter(Collision collision)
    {
        // only trigger if it's the player and we haven't already triggered
        if (hasTriggered || !collision.gameObject.CompareTag("Player"))
        {
            return;
        }

        hasTriggered = true;


        var collider = GetComponent<Collider>();
        if (collider != null)
        {
            collider.enabled = false;
        }

        // call the hud manager to show the kill comments (active or passive) and despawn the object
        var hud = Hud.GetComponent<hudManager>();
        if (isActiveKill)
        {
            hud.StartCoroutine(hud.ShowKill(gameObject, track, name, activeKillComments));
        }
        else
        {
            hud.StartCoroutine(hud.ShowKill(gameObject, track, name, passiveKillComments));
        }
    }
}
