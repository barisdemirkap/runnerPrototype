using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{   
    public static GameManager instance;
	public GameState state;
	void Awake()
	{
		instance = this;
	}
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

	public void updateGameState (GameState newState)
	{
		state = newState;

		switch (newState)
		{
			case GameState.Enrty:
				break;
			case GameState.InGame:
				break;
			case GameState.Victory:
				break;
			case GameState.Lose:
				break;
		}
	}
}

public enum GameState 
{	
	Enrty,
	InGame,
	Victory,
	Lose
}
