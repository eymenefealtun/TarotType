﻿namespace TarotType.Main.Utilities.Words.Kurdish
{
    public class Kurdish : Language     
    {
        string _path = @"Words\Kurdish\Kurdish.txt";
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
