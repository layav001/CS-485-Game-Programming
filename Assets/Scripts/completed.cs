using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class completed : MonoBehaviour
{
    [SerializeField] private string main_menu;
    [SerializeField] private string next_level;
    [SerializeField] private string play_again; 

    public int buttonWidth;
    public int buttonHeight;
    private int origin_x;
    private int origin_y;
    public GUISkin mySkin;
    public GUIStyle style;
    

    // Start is called before the first frame update
    void Start()
    {
        buttonWidth = 300;
        buttonHeight = 150;
        origin_x = Screen.width / 2 - buttonWidth / 3;
        origin_y = Screen.height / 2 - buttonWidth / 2;
    }


    // Update is called once per frame
    void OnGUI()
    {
        if (GUI.Button(new Rect(origin_x - 400, origin_y + 300, buttonWidth, buttonHeight), "Play Again", style))
        {
            SceneManager.LoadScene(play_again);
        }
        
        if (GUI.Button(new Rect(origin_x + 330, origin_y + 300, buttonWidth, buttonHeight), "Main Menu",style))
        {
            SceneManager.LoadScene(main_menu);         
        }

        if (GUI.Button(new Rect(origin_x - 40, origin_y + 300, buttonWidth, buttonHeight), "Next Level", style))
        {
            SceneManager.LoadScene(next_level);
        }

        /*
        if (GUI.Button(new Rect(origin_x, (origin_y + buttonHeight * 2) - 100, buttonWidth, buttonHeight), "Main Menu", style))
        {
            //Application.LoadLevel(3);
#if UNITY_EDITOR
            UnityEditor.EditorApplication.isPlaying = false;
#else
			    Application.Quit(); 
#endif

        }
        */

    }

}
