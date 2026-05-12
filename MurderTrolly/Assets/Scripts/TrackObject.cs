using UnityEngine;

public class TrackObject : MonoBehaviour
{
    [SerializeField] private int track;
    [SerializeField] private GameObject Hud;

    public string name;
    public string[] killComments;

    void OnCollisionEnter(Collision collision)
    {
        Hud.GetComponent<hudManager>().ShowKill(track, name, killComments);
    }
}
