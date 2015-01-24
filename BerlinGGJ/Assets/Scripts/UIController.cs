using UnityEngine;

public class UIController : MonoBehaviour
{
	private enum States
	{
		None,
		Pause,
		GameOver,
		Win
	}
	
	private struct Buttons
	{
		public const int HEIGHT = 50;
		public const int WIDTH = 130;
		public const int GAP = 30;
	}
	
	States state = States.None;
	States lastState = States.None;
	
	[SerializeField]
	GameObject Menu;
	GameObject ContinueB;
	GameObject RestartB;
	
	
	void Awake()
	{
		if( Menu == null ) Menu = GameObject.Find("EscapeMenu");
		ContinueB = Menu.transform.Find("Canvas/ContinueButton").gameObject;
		RestartB = Menu.transform.Find("Canvas/RestartButton").gameObject;
		Menu.SetActive( false );
	}
	
	void Update()
	{
		if( Input.GetKeyDown( KeyCode.Escape ) )
		{
			if( state == States.Pause ) UnpauseGame();
			else PauseGame();
		}
	}
	
	public void SetGameOver()
	{
		ContinueB.SetActive( false );
		RestartB.SetActive( true );
//		Camera.main.GetComponent<BlurEffect>().enabled = true;
		Menu.SetActive( true );
		Screen.showCursor = true;
		lastState = state;
		Time.timeScale = 1f; // stop game (or) run in background
		state = States.GameOver;
	}
	
	public void SetWin()
	{
		Screen.showCursor = true;
		// TODO : remove presentation hack
		SetGameOver();
		/*
		ContinueB.SetActive( false );
		NextLevelB.SetActive( true );
		RestartB.SetActive( false );
		Menu.SetActive( true );
		lastState = state;
		state = States.Win;
		*/
	}
	
	public void Hide()
	{
		lastState = state;
		state = States.None;
	}
	
	void PauseGame()
	{
//		Camera.main.GetComponent<BlurEffect>().enabled = true;
		ContinueB.SetActive( true );
		RestartB.SetActive( true );
		Menu.SetActive( true );
		lastState = state;
		Time.timeScale = 0f;
		state = States.Pause;
		Screen.showCursor = true;
	}
	
	public void UnpauseGame()
	{
//		Camera.main.GetComponent<BlurEffect>().enabled = false;
		Menu.SetActive( false );
		state = lastState;
		Time.timeScale = 1f;
		Screen.showCursor = false;
	}
	
	public void RestartLevel()
	{
		lastState = state;
		Time.timeScale = 1f;
		Application.LoadLevel( Application.loadedLevel );
		state = States.None;
		Screen.showCursor = false;
	}
	
	public void NextLevel()
	{
		lastState = state;
		Time.timeScale = 1f;
		Application.LoadLevel( Application.loadedLevel + 1 );
		state = States.None;
		Screen.showCursor = false;
	}
	
	public void BackToMenu()
	{
		lastState = state;
		Time.timeScale = 1f;
//		Application.LoadLevel( Constants.LEVEL_MENU );
		state = States.None;
		Screen.showCursor = true;
	}
}
