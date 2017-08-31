﻿using System.Runtime.Serialization;

namespace NGitLab.Models
{
    [DataContract]
    public class BranchCreate
    {
        [DataMember(Name = "branch")]
        public string Name;

        [DataMember(Name = "ref")]
        public string Ref;
    }
}