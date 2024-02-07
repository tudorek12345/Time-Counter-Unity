using UnityEngine;
using TMPro;

public class TimeCounter : MonoBehaviour
{
    public TMP_Text timeText;
    public TMP_FontAsset customFont;
    public Color textColor = new Color(1f, 0.5f, 0.2f); // Custom text color
    public int fontSize = 24;

    private float startTime;

    void Start()
    {
        startTime = Time.time;

        // Apply custom font, color, and size to the TextMeshPro text
        timeText.font = customFont;
        timeText.color = textColor;
        timeText.fontSize = fontSize;
    }

    void Update()
    {
        // Calculate the elapsed time since the game started
        float elapsedTime = Time.time - startTime;

        // Format the time as minutes and seconds
        string minutes = ((int)elapsedTime / 60).ToString("00");
        string seconds = (elapsedTime % 60).ToString("00");

        // Update the TextMeshPro text with the elapsed time
        timeText.text = "Time survived: " + minutes + ":" + seconds;
    }
}
