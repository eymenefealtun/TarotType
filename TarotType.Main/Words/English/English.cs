﻿namespace TarotType.Main.Utilities.Words.English
{       
    public class English : Language
    {
        string _path = @"Words\EnglishFolder\English.txt";
        SourceManager.flowDirections _flowDirection = SourceManager.flowDirections.left;
        public override SourceManager.flowDirections FlowDirection()
        {
            return _flowDirection;
        }

        public override string Path()
        {
            return _path;
        }
    }
}