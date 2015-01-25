using UnityEngine;
using System.Collections;

public class SoundManager : MonoBehaviour 
{

	[SerializeField] public AudioClip playerWalk;
	[SerializeField] public AudioClip playerJump;
	[SerializeField] public AudioClip playerLanding;
	[SerializeField] public AudioClip playerDeath;

	[SerializeField] public AudioClip projectile1;
	[SerializeField] public AudioClip projectile2;
	[SerializeField] public AudioClip projectile3;
	[SerializeField] public AudioClip projectile4;
	[SerializeField] public AudioClip projectile5;

	[SerializeField] public AudioClip enemyWalk;
	[SerializeField] public AudioClip enemyJump;
	[SerializeField] public AudioClip enemyShoot;
	[SerializeField] public AudioClip enemyDeath;

	[SerializeField] public AudioClip bossWalk;
	[SerializeField] public AudioClip bossShoot1;
	[SerializeField] public AudioClip bossShoot2;
	[SerializeField] public AudioClip bossScream;
	[SerializeField] public AudioClip bossAmbient;
	[SerializeField] public AudioClip bossDeath;

	[SerializeField] public AudioClip itemDrop;
	[SerializeField] public AudioClip itemCollect;

	[SerializeField] public AudioClip buttonClick;

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
			_audioSource = GameObject.FindGameObjectWithTag("SoundSource").GetComponent<AudioSource>();
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

	public void Play(AudioClip audioClip, bool loop = false)
	{
		_audioSource.loop = loop;

		_audioSource.clip = audioClip;
		_audioSource.Play();
	}

	public void Stop()
	{
		if (_audioSource.isPlaying) {
					_audioSource.Stop ();
			}
	}
}
