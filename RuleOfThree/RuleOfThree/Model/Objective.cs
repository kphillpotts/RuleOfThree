using System;

namespace RuleOfThree
{
    public enum ObjectiveStatus
    {
        None = 0,
        InProgress = 1,
        PushedForward = 2,
        Done = 3
    }

    public class Objective
    {
        public Objective()
        {
        }

        public string Title
        {
            get;
            set;
        }
        public ObjectiveStatus Status
        {
            get;
            set;
        }
    }
}

