﻿using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.IO;
using System.Linq;

namespace RPSonline.AoC.E2018.Days
{
    [Export(typeof(IDay))]
    [ExportMetadata("Year", Consts.AOC_YEAR)]
    [ExportMetadata("Day", AOC_DAY)]
    class Day18 : IDay
    {
        private const int AOC_DAY = 18;

        private readonly string[] _input;

        public Day18()
        {
            _input = File.ReadAllLines(FileHelper.GetInputLocation(AOC_DAY, Consts.AOC_YEAR));
        }

        public AnswerModel Solve()
        {
            AnswerModel answer = new AnswerModel();

            return answer;
        }
    }
}
