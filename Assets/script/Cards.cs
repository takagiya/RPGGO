using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Cards : MonoBehaviour{


/*
private Vector2[] OffSet;
private int jokerNum = 1;
	private static string[] kind = new string[]{
		"SA", "S2", "S3", "S4", "S5", "S6", "S7", "S8", "S9", "S10", "SJ", "SQ", "SK",
		"HA", "H2", "H3", "H4", "H5", "H6", "H7", "H8", "H9", "H10", "HJ", "HQ", "HK",
		"DA", "D2", "D3", "D4", "D5", "D6", "D7", "D8", "D9", "D10", "DJ", "DQ", "DK",
		"CA", "C2", "C3", "C4", "C5", "C6", "C7", "C8", "C9", "C10", "CJ", "CQ", "CK",
		"J0", "J1"
	};
	//public static Vector2[] OffSets{ get { return Instance.OffSet; } }
	public static string[] Kind{ get { return kind; } }
	private static List<int> number = new List<int>();
	public static List<int> Number{ get { return number; } }
	private static List<int> suits = new List<int>();
	public static List<int> Suits{ get { return suits; } }
	public static CardKind[] Kinds;

	public static List<int> Stock = new List<int>();
	public static List<List<int>> Players = new List<List<int>>();
	public static List<int> Layout = new List<int>();
	public static List<int> Discarded = new List<int>();

	Cards(){
		Kinds = new CardKind[]{
			new CardKind(Suit.Spade, 1),
			new CardKind(Suit.Spade, 2),
			new CardKind(Suit.Spade, 3),
			new CardKind(Suit.Spade, 4),
			new CardKind(Suit.Spade, 5),
			new CardKind(Suit.Spade, 6),
			new CardKind(Suit.Spade, 7),
			new CardKind(Suit.Spade, 8),
			new CardKind(Suit.Spade, 9),
			new CardKind(Suit.Spade, 10),
			new CardKind(Suit.Spade, 11),
			new CardKind(Suit.Spade, 12),
			new CardKind(Suit.Spade, 13),
			new CardKind(Suit.Heart, 1),
			new CardKind(Suit.Heart, 2),
			new CardKind(Suit.Heart, 3),
			new CardKind(Suit.Heart, 4),
			new CardKind(Suit.Heart, 5),
			new CardKind(Suit.Heart, 6),
			new CardKind(Suit.Heart, 7),
			new CardKind(Suit.Heart, 8),
			new CardKind(Suit.Heart, 9),
			new CardKind(Suit.Heart, 10),
			new CardKind(Suit.Heart, 11),
			new CardKind(Suit.Heart, 12),
			new CardKind(Suit.Heart, 13),
			new CardKind(Suit.Diamond, 1),
			new CardKind(Suit.Diamond, 2),
			new CardKind(Suit.Diamond, 3),
			new CardKind(Suit.Diamond, 4),
			new CardKind(Suit.Diamond, 5),
			new CardKind(Suit.Diamond, 6),
			new CardKind(Suit.Diamond, 7),
			new CardKind(Suit.Diamond, 8),
			new CardKind(Suit.Diamond, 9),
			new CardKind(Suit.Diamond, 10),
			new CardKind(Suit.Diamond, 11),
			new CardKind(Suit.Diamond, 12),
			new CardKind(Suit.Diamond, 13),
			new CardKind(Suit.Club, 1),
			new CardKind(Suit.Club, 2),
			new CardKind(Suit.Club, 3),
			new CardKind(Suit.Club, 4),
			new CardKind(Suit.Club, 5),
			new CardKind(Suit.Club, 6),
			new CardKind(Suit.Club, 7),
			new CardKind(Suit.Club, 8),
			new CardKind(Suit.Club, 9),
			new CardKind(Suit.Club, 10),
			new CardKind(Suit.Club, 11),
			new CardKind(Suit.Club, 12),
			new CardKind(Suit.Club, 13),
			new CardKind(Suit.Joker, 0),
			new CardKind(Suit.Joker, 0)
		};
	}


}
/*
[System.Serializable]
public class CardKind{
	public Suit suit;
	public int number;
	public CardKind(Suit suit, int number){
		this.suit = suit;
		this.number = number;
	}
}

public enum Suit{
	Spade,
	Heart,
	Diamond,
	Club,
	Joker,
}*/

}
