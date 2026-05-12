using UnityEngine;
using TMPro;
using System.Collections;
using UnityEngine.SceneManagement;

public class hudManager : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI textBox;

    [TextArea(3, 10)]

    [SerializeField] private float typingSpeed = 0.05f;
    [SerializeField] private float deletingSpeed = 0.03f;
    [SerializeField] private float lineDelay = 1.5f;
    [SerializeField] private float cursorBlinkSpeed = 0.5f;
    [SerializeField] private float startDelay = 0.5f;
    [SerializeField] private string nextLevel = "";

    private string currentText = "";
    private bool showCursor = true;

    void Start()
    {
        StartCoroutine(CursorBlink());
    }

    public IEnumerator ShowKill(GameObject objectToDespawn, int track, string name, string[] killComments)
    {
        Destroy(objectToDespawn);

        for (int i = 0; i < killComments.Length; i++)
        {
            yield return new WaitForSeconds(startDelay);

            yield return StartCoroutine(TypeLine(killComments[i]));
            yield return new WaitForSeconds(lineDelay);

            if (i < killComments.Length - 1)
            {
                yield return StartCoroutine(DeleteLine());
            }
            
            if (i == killComments.Length - 1)
            {
                yield return StartCoroutine(DeleteLine());
                yield return StartCoroutine(TypeLine("Ok let's move on..."));
                yield return new WaitForSeconds(lineDelay);
                SceneManager.LoadScene(nextLevel);
            }
        }
    }

    IEnumerator TypeLine(string line)
    {
        currentText = "";
        UpdateText();

        foreach (char c in line)
        {
            currentText += c;
            UpdateText();
            yield return new WaitForSeconds(typingSpeed);
        }
    }

    IEnumerator DeleteLine()
    {
        while (currentText.Length > 0)
        {
            currentText = currentText.Substring(0, currentText.Length - 1);
            UpdateText();
            yield return new WaitForSeconds(deletingSpeed);
        }
    }

    IEnumerator CursorBlink()
    {
        while (true)
        {
            showCursor = !showCursor;
            UpdateText();
            yield return new WaitForSeconds(cursorBlinkSpeed);
        }
    }

    void UpdateText()
    {
        string cursor = showCursor ? "|" : "<color=#00000000>|</color>";
        textBox.text = currentText + cursor;
    }
}