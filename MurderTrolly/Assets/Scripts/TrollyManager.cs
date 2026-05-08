using UnityEngine;

public class TrollyManager : MonoBehaviour
{
    public float speed = 5.0f;
    public int pathChoice = 1;

    private bool reachedMiddle = false;
    private bool reachedPathMiddle = false;
    private bool reachedPathEnd = false;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    [SerializeField] private Transform startPos;
    [SerializeField] private Transform middlePos;
    [SerializeField] private Transform middle1Pos;
    [SerializeField] private Transform middle2Pos;
    [SerializeField] private Transform end1Pos;
    [SerializeField] private Transform end2Pos;
    [SerializeField] private Canvas Buttons;
    [SerializeField] private Camera povCamera;
    [SerializeField] private Camera topDownCamera;

    void Start()
    {
        povCamera.gameObject.SetActive(false);
        topDownCamera.gameObject.SetActive(true);
    }
    
    public void SetPath(int choice)
    {
        this.pathChoice = choice;
    }

    // Update is called once per frame
    void Update()
    {
        float step =  speed * Time.deltaTime; // calculate distance to move
        if (!reachedMiddle)
        {
            transform.position = Vector3.MoveTowards(transform.position, middlePos.position, step);
            if (transform.position == middlePos.position)
            {
                reachedMiddle = true;
            }
        } else if (!reachedPathMiddle)
        {
            povCamera.gameObject.SetActive(true);
            topDownCamera.gameObject.SetActive(false);
            Buttons.gameObject.SetActive(false);
            if (pathChoice == 1)
            {
                transform.position = Vector3.MoveTowards(transform.position, middle1Pos.position, step);
                if (transform.position == middle1Pos.position)
                {
                    reachedPathMiddle = true;
                }
            } else if (pathChoice == 2)
            {
                transform.position = Vector3.MoveTowards(transform.position, middle2Pos.position, step);
                if (transform.position == middle2Pos.position)
                {
                    reachedPathMiddle = true;
                }
            }
        } else if (!reachedPathEnd)
        {
            if (pathChoice == 1)
            {
                transform.position = Vector3.MoveTowards(transform.position, end1Pos.position, step);
                if (transform.position == end1Pos.position)
                {
                    reachedPathEnd = true;
                }
            } else if (pathChoice == 2)
            {
                transform.position = Vector3.MoveTowards(transform.position, end2Pos.position, step);
                if (transform.position == end2Pos.position)
                {
                    reachedPathEnd = true;
                }
            }
        }
    }
}
