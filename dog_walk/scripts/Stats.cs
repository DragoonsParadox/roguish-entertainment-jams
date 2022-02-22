using System;

public class Stats
{
    // Declare member variables here. Examples:
    // private int a = 2;
    // private string b = "text";
    /*None,show,streetfight dogs,police dogs,malnourished,healthy*/
    public enum PT{
        MALNOURISHED,
        FIGHT_DOG,
        POLICE_DOG,
        SHOW,
        HEALTHY,
        NONE
    }
    private int hp,str,spd,res,agg;
    private bool isStray;
    private int[] modifiers;
    private int lv;
    private PT pt;
    // Generates random stats with a simple 10 point variance.
    void Stats(int[] mod, PT pT, bool stray, int genLv){
        modifiers = mod;
        // HP's modifier has a flat benefit.
        hp = Math.random() * 20 - 10 + mod[0];
        // Strength
        str = Math.random() * 40 - 20 + mod[1];
        // Speed's modifier has a flat benefit.
        spd = Math.random() * 20 - 10 + mod[2];
        // Resilience
        res = Math.random() * 40 - 20 + mod[3];
        // Aggression
        agg = 20 + mod[4] + stray ? 30 : 0;
        isStray = stray;
        lv = genLv;
        pt = pT;
        switch(pT){
            case PT.MALNOURISHED:
                hp -= 15;
                agg += 20;
                break;
            case PT.FIGHT_DOG:
                hp -= 10;
                str += 20;
                agg += 30;
                break;
            case PT.HEALTHY:
                hp += 15;
                agg -= 20;
                break;
            case PT.NONE:
                break;
            case PT.POLICE_DOG:
                hp += 20;
                str += 30;
                agg -= 30;
                break;
            case PT.SHOW:
                hp -= 10;
                str += 10;
                agg -= 10;
                break;
            default:
                throw new ArgumentException();
                break;
        }
        for(int i = 1; i < genLv; i++){
            hp += mod[0];
            str = str * 1.1 > 200 ? 200 : str * 1.1;
        }
    }

    void Stats(int health, int healthIncrease, int strength, int speed, int resilience, int aggression, int genLv){
        hp = health;
        str = strength;
        spd = speed;
        res = resilience;
        agg = aggression;
        lv = genLv;
        modifiers = new int[5];
        modifiers[0] = healthIncrease;
    }

    public int getHP(){
        return hp;
    }

    public int getStr(){
        return str;
    }

    public int getSpd(){
        return spd;
    }

    public int getRes(){
        return res;
    }

    public int getAgg(){
        return agg;
    }
    
    public bool getStray(){
        return isStray;
    }

    public void setStray(bool status){
        isStray = status;
    }

    public int getLV(){
        return lv;
    }

    public PT getPT(){
        return pt;
    }
//  // Called every frame. 'delta' is the elapsed time since the previous frame.
//  public override void _Process(float delta)
//  {
//      
//  }
}
