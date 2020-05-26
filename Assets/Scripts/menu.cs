using UnityEngine;
using UnityEngine.SceneManagement;

public class menu : MonoBehaviour
{
    public int buttonWidth;
    public int buttonHeight;
    private int origin_x;
    private int origin_y;
    public GUISkin mySkin;
    public GUIStyle style;

    // Start is called before the first frame update
    void Start()
    {
        buttonWidth = 500;
        buttonHeight = 250;
        origin_x = Screen.width / 2 - buttonWidth / 3;
        origin_y = Screen.height / 2 - buttonWidth / 2;
    }
    

    // Update is called once per frame
    void OnGUI()
    {
        if (GUI.Button(new Rect(origin_x - 600, (origin_y + buttonHeight * 2) - 400, buttonWidth, buttonHeight), "Level 1",style))
        {
            SceneManager.LoadScene(1); 
        }
        
        if (GUI.Button(new Rect(origin_x - 50, (origin_y + buttonHeight * 2) - 400, buttonWidth, buttonHeight), "Level 2", style))
        {
            SceneManager.LoadScene(2);
        }
        if (GUI.Button(new Rect(origin_x + 500, (origin_y + buttonHeight * 2) - 400, buttonWidth, buttonHeight), "Level 3", style))
        {
            SceneManager.LoadScene(3);
        }
        if (GUI.Button(new Rect(origin_x - 50, (origin_y + buttonHeight * 2) - 100, buttonWidth, buttonHeight), "Exit",style))
        {
            //Application.LoadLevel(3);
            #if UNITY_EDITOR
                UnityEditor.EditorApplication.isPlaying = false;
            #else
			    Application.Quit(); 
            #endif
        }

    }

}