﻿namespace GameLogic.Game
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
       
    using GameLogic.Fields;
    using GameLogic.Fields.Institutions;
    using GameLogic.Game;
    using GameLogic.Map;
    using Interfaces;

    public class Game : IRollScoreRouls
    {
        private List<Player> players;
        private GameSettings settings;
        private Map map;

        // when the dice is roll there will be calculation of the points player gets from that roll.
        // public virtual CalculateRollScore(IEnumerable<IRollScoreRouls<int>> results)
        // {
        // }
    }
}