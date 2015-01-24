using UnityEngine;
using UnityEngine.UI;

public class ButtonEvents : MonoBehaviour 
{

	public void StartOnClick()
	{
		Debug.LogWarning( "Start" );
	}

	
	public void QuitOnClick()
	{
		Application.Quit();
	}
}