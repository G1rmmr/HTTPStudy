using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 1. 데이터 제작 ->저장할 데이터 생성
class Data
{
    public string nickname;
	public int level;
	public int coin = 100;
	public bool skill;
    // 저장하고 싶은 데이터를 클래스화 시킴
}

public class JSONTest : MonoBehaviour
{
    Data Player = new Data() {
		nickname = "G1rmmr",
        level = 1,
        coin = 100,
        skill = false
	};

    void Start()
    {
		// 2. Json으로 변환
        string JsonData = JsonUtility.ToJson(Player);
        print(JsonData);

        Data Player2 = JsonUtility.FromJson<Data>(JsonData);

		print(Player2.nickname);
		print(Player2.level);
		print(Player2.coin);
		print(Player2.skill);
	}
}
