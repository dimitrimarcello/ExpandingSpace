using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Achievements : MonoBehaviour {

    public Text[] tiers;
    private float highScore;
    private void Awake()
    {
        highScore = PlayerPrefs.GetFloat("HighScore", 0);
        tiers[8].text = "HighScore: " + highScore;
    }
    private void Update()
    {
        if(highScore > 5000)
        {
            tiers[0].text = "A FULL NASA SPACE SUIT COSTS $12,000,000.";
        }
        if (highScore > 20000)
        {
            tiers[1].text = "NEUTRON STARS CAN SPIN 600 TIMES PER SECOND.";
        }
        if (highScore > 25000)
        {
            tiers[2].text = "THERE MAY BE A PLANET MADE OUT OF DIAMONDS.";
        }
        if (highScore > 30000)
        {
            tiers[3].text = "THE FOOTPRINTS ON THE MOON WILL BE THERE FOR 100 MILLION YEARS.";
        }
        if (highScore > 35000)
        {
            tiers[4].text = "ONE DAY ON VENUS IS LONGER THAN ONE YEAR.";
        }
        if (highScore > 50000)
        {
            tiers[5].text = "IN 3.75 BILLION YEARS THE MILKY WAY AND ANDROMEDA GALAXIES WILL COLLIDE.";
        }
        if (highScore > 70000)
        {
            tiers[0].text = "IF TWO PIECES OF THE SAME TYPE OF METAL TOUCH IN SPACE THEY WILL PERMANENTLY BOND.";
        }
        if (highScore > 100000)
        {
            tiers[0].text = "THE MOON WAS ONCE A PIECE OF THE EARTH.";
        }
    }
}
