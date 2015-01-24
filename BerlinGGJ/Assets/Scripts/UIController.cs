using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;


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

	[SerializeField]
	Texture emptySlot;

	GameObject gameUI;
	
	PlayerBase _playerBase;

	bool[] slotStatus;
	int slotCount;

	void Start()
	{
		if( Menu == null ) Menu = GameObject.Find("EscapeMenu");
		ContinueB = Menu.transform.Find("Canvas/ContinueButton").gameObject;
		RestartB = Menu.transform.Find("Canvas/RestartButton").gameObject;
		Menu.SetActive( false );

		for (int i = 0; i < slotCount; i++) {
			slotStatus[i] = false;
		}

		_playerBase = GameObject.FindWithTag(Tags.PLAYER).GetComponent<PlayerBase>();
		_playerBase.PlayerInventory.OnInventoryAdded += OnInventoryAdded;
		_playerBase.PlayerInventory.OnInventoryRemoved += OnInventoryRemoved;

		gameUI = GameObject.FindWithTag(Tags.GAMEUI);
	}
	
	void Update()
	{
		if( Input.GetKeyDown( KeyCode.Escape ) )
		{
			if( state == States.Pause ) UnpauseGame();
			else PauseGame();
		}
	}

	void OnInventoryAdded(ItemBase itemBase)
	{
		syncInventory();
	}

	void OnInventoryRemoved(ItemBase itemBase)
	{
		syncInventory();
	}

	void syncInventory()
	{
		List<ItemBase> itemBaseList = _playerBase.PlayerInventory.ItemBaseList();
		Debug.Log ("sync itemBaseList.Count: " + itemBaseList.Count);
		for (int i = 0; i < _playerBase.PlayerInventory.MaximumNumberOfItems() ; i++) {
			if(itemBaseList.Count> i){
				gameUI.transform.Find("Canvas/ItemSlot" + i).GetComponent<RawImage>().texture = itemBaseList[i].ItemProperty.SlotImage();
			}else{
				gameUI.transform.Find("Canvas/ItemSlot" + i).GetComponent<RawImage>().texture = emptySlot;
			}
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
