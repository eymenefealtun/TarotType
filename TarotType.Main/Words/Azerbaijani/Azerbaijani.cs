﻿namespace TarotType.Main.Utilities.Words.Azerbaijani
{
    public class Azerbaijani : Language
    {
        
        string _path = @"Words\Azerbaijani\Azerbaijani.txt";
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
