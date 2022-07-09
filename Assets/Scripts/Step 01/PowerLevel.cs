using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Functions to complete:
/// - ReturnMyDancePowerLevel
/// - ReturnChanceToWin
/// </summary>
public class PowerLevel : MonoBehaviour
{
    public StatsSystem myStats; // a reference to our stats system

    /// <summary>
    /// Used to generate a number of battle points that is used in combat.
    /// </summary>
    /// <returns></returns>

    public float myChanceToWin = 0f;
    public int myPowerLevel = 0;
    public float totalPower = 0f;


    public int ReturnMyDancePowerLevel()
    {
        // let's set our player power levels, using an algorithm, the simpliest would be luck + style + rhythm
        int myLuck = myStats.luck;
        int myStyle = myStats.style;
        int myRhthm = myStats.rhythm;

        myPowerLevel = myLuck + myStyle + myRhthm;

        return myPowerLevel; // instead of returning 0 we probably want to return our current power level
    }

    /// <summary>
    /// Returns the chance to win a fight given the two powerlevels 
    /// </summary>
    /// <param name="myPowerLevel"></param>
    /// <param name="opponentPowerLevel"></param>
    /// <returns></returns>
    public float ReturnChanceToWin(int myPowerLevel,int opponentPowerLevel)
    {
        // let's first calculate the total power level overall.
        totalPower = myPowerLevel + opponentPowerLevel;

        // Then let's then do a fraction of my power level and the overall power level.
        float myChanceToWin = myPowerLevel / totalPower * 100;
        // This will give us a decimal number, i.e. 3/4 will give us 0.75 we probably want to turn that into the percentage value.

        return myChanceToWin; // Instead of returning 0 here we probably want to return our percentage chance to win.
    }

    #region NoModificationsRequired
    public void TestImplementation()
    {
        int opponentPower = Random.Range(0, 20);
        int myPowerLevel = ReturnMyDancePowerLevel();
          
        float myChanceToWin = ReturnChanceToWin(myPowerLevel, opponentPower);
        float myOpponentChanceToWin = ReturnChanceToWin(opponentPower, myPowerLevel);

        Debug.Log(string.Format("My power is {0}, my opponents powerlevel is {1}, my chance to win is {2}% and my opponents is {3}%", myPowerLevel, opponentPower, myChanceToWin, myOpponentChanceToWin));
    }
    #endregion
}
