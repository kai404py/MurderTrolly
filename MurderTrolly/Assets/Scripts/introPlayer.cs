using UnityEngine;
using TMPro;
using System.Collections;
using UnityEngine.SceneManagement;

public class IntroPlayer : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI textBox;

    [TextArea(3, 10)]
    [SerializeField] private string[] storyLines;

    [SerializeField] private float typingSpeed = 0.05f;
    [SerializeField] private float deletingSpeed = 0.03f;
    [SerializeField] private float lineDelay = 1.5f;
    [SerializeField] private float cursorBlinkSpeed = 0.5f;
    [SerializeField] private float startDelay = 0.5f;

    [SerializeField] private bool end = false;

    private string currentText = "";
    private bool showCursor = true;

    void Start()
    {
        StartCoroutine(CursorBlink());
        StartCoroutine(PlayIntro());
    }

    // plays the intro story by typing out each line, waiting, then deleting it before moving to the next line
    IEnumerator PlayIntro()
    {
        for (int i = 0; i < storyLines.Length; i++)
        {
            yield return new WaitForSeconds(startDelay);

            yield return StartCoroutine(TypeLine(storyLines[i]));
            yield return new WaitForSeconds(lineDelay);

            if (i < storyLines.Length - 1)
            {
                yield return StartCoroutine(DeleteLine());
            }
        }

        if (!end)
        {
            SceneManager.LoadScene("Level 1");
        }
    }

    // types out a line character by character with a delay between each character
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

    // deletes the current line character by character with a delay between each character
    IEnumerator DeleteLine()
    {
        while (currentText.Length > 0)
        {
            currentText = currentText.Substring(0, currentText.Length - 1);
            UpdateText();
            yield return new WaitForSeconds(deletingSpeed);
        }
    }

    // blinks the cursor on and off by toggling the showCursor boolean and updating the text
    IEnumerator CursorBlink()
    {
        while (true)
        {
            showCursor = !showCursor;
            UpdateText();
            yield return new WaitForSeconds(cursorBlinkSpeed);
        }
    }

    // updates the text in the text box to the current text plus a cursor that is either visible or invisible based on the showCursor boolean
    void UpdateText()
    {
        string cursor = showCursor ? "|" : "<color=#00000000>|</color>";
        textBox.text = currentText + cursor;
    }
}