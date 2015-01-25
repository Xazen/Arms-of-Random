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

	private AudioSource[] _audioSource = new AudioSource[4];

	public static int PLAYER = 0;
	public static int ENEMY = 1;
	public static int BOSS = 2;
	public static int ENVIRONMENT = 3;

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
			AudioSource[] audioSources = GetComponents<AudioSource>();
			_audioSource[0] = audioSources[0];
			_audioSource[1] = audioSources[1];
			_audioSource[2] = audioSources[2];
			_audioSource[3] = audioSources[3];
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

	public void Play(AudioClip audioClip, bool loop = false, int audioSourceIndex = 0)
	{
		_audioSource[audioSourceIndex].loop = loop;

		_audioSource[audioSourceIndex].clip = audioClip;
		_audioSource[audioSourceIndex].Play();
	}

	public void Stop(int audioSourceIndex = 0)
	{
		if (_audioSource[audioSourceIndex].isPlaying) {
			_audioSource[audioSourceIndex].Stop ();
			}
	}
}
