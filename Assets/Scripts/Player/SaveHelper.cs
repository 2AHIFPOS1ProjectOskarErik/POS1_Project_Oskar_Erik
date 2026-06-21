using UnityEngine;

public class SaveHelper
{
    public int Coins;
    public double Hp;
    public double MaxHP;
    public int Current_Checkpoint;
    public bool BossAlive;
    public bool MinibossAlive;

    public SaveHelper(int coins, double hp, double maxHP, int current_Checkpoint, bool bossAlive, bool minibossAlive)
    {
        Coins = coins;
        Hp = hp;
        MaxHP = maxHP;
        Current_Checkpoint = current_Checkpoint;
        BossAlive = bossAlive;
        MinibossAlive = minibossAlive;
    }
}
