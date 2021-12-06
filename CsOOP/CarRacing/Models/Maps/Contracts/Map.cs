using CarRacing.Models.Racers.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarRacing.Models.Maps.Contracts
{
    public class Map : IMap
    {
        public string StartRace(IRacer racerOne, IRacer racerTwo)
        {
            if (!racerOne.IsAvailable() && !racerTwo.IsAvailable())
            {
                return "Race cannot be completed because both racers are not available!";
            }
            else if (!racerOne.IsAvailable())
            {
                return $"{racerTwo.Username} wins the race! {racerOne.Username} was not available to race!";
            }
            else if (!racerTwo.IsAvailable())
            {
                return $"{racerOne.Username} wins the race! {racerTwo.Username} was not available to race!";
            }
            else
            {
                racerOne.Race();
                racerTwo.Race();

                double racerOneBehaviourPoints;
                if (racerOne.RacingBehavior == "strict") racerOneBehaviourPoints = 1.2;
                else racerOneBehaviourPoints = 1.1;

                var racerOneChanceOfWin = racerOne.DrivingExperience * racerOne.Car.HorsePower * racerOneBehaviourPoints;

                double racerTwoBehaviourPoints;
                if (racerTwo.RacingBehavior == "strict") racerTwoBehaviourPoints = 1.2;
                else racerTwoBehaviourPoints = 1.1;

                var racerTwoChanceOfWin = racerTwo.DrivingExperience * racerTwo.Car.HorsePower * racerTwoBehaviourPoints;

                IRacer winner;
                if (racerOneChanceOfWin > racerTwoChanceOfWin)
                {
                    winner = racerOne;
                }
                else
                {
                    winner = racerTwo;
                }

                return $"{racerOne.Username} has just raced against {racerTwo.Username}! {winner.Username} is the winner!";
            }


        }
    }
}
