using UnityEngine;
using System.Collections;

public class SoundManager : MonoBehaviour 
{

	[SerializeField] private AudioClip playerWalk;
	[SerializeField] private AudioClip playerJump;
	[SerializeField] private AudioClip playerLanding;
	[SerializeField] private AudioClip playerDeath;

	[SerializeField] private AudioClip projectile1;
	[SerializeField] private AudioClip projectile2;
	[SerializeField] private AudioClip projectile3;
	[SerializeField] private AudioClip projectile4;
	[SerializeField] private AudioClip projectile5;

	[SerializeField] private AudioClip enemyWalk;
	[SerializeField] private AudioClip enemyJump;
	[SerializeField] private AudioClip enemyShoot;
	[SerializeField] private AudioClip enemyDeath;

	[SerializeField] private AudioClip bossWalk;
	[SerializeField] private AudioClip bossShoot1;
	[SerializeField] private AudioClip bossShoot2;
	[SerializeField] private AudioClip bossScream;
	[SerializeField] private AudioClip bossAmbient;
	[SerializeField] private AudioClip bossDeath;

	[SerializeField] private AudioClip itemDrop;
	[SerializeField] private AudioClip itemCollect;

	[SerializeField] private AudioClip buttonClick;

	private AudioSource _audioSource;
	
	private static SoundManager _SoundManager;
	public static SoundManager sharedManager
	{
		get{
			if (_SoundManager == null)
			{
				_SoundManager = GameObject.FindObjectOfType<SoundManager>();
			}
			return _SoundManager;
		}
	}

	void Awake()
	{
		if (_SoundManager == null) 
		{
			_audioSource = GameObject.FindGameObjectWithTag(Tags.GAMECONTROLLER).GetComponent<AudioSource>();
			_SoundManager = this;
			DontDestroyOnLoad (this);
		} 
		else 
		{
			if (this != _SoundManager)
			{
				Destroy(this.gameObject);
			}
		}
	}

	public void Play(AudioClip audioClip, bool loop)
	{
		_audioSource.loop = loop;

		_audioSource.clip = audioClip;
//		_audioSource.Play (audioClip);
	}
}
