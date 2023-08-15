﻿namespace Utilities.Words.Spanish
{
    public class Spanish : Language
    {
        string _path = @"Words\Spanish\Spanish-636.598.txt";
        string _flowDirection = "left";

        public override string FlowDirection()
        {
            return _flowDirection;
        }

        public override string Path()
        {
            return _path;
        }
    }
}