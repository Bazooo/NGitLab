﻿using System.ComponentModel;
using System.Runtime.Serialization;

namespace NGitLab.Models
{
    [DataContract]
    public class MergeRequestCreate
    {
        [DataMember(Name = "source_branch")]
        public string SourceBranch;

        [DataMember(Name="target_branch")]
        public string TargetBranch;

        [DataMember(Name="assignee_id")]
        public int? AssigneeId;

        [DataMember(Name="title")]
        public string Title;

        [DataMember(Name = "description")]
        public string Description;

        [DataMember(Name="target_project_id")]
        public int? TargetProjectId;

        [DataMember(Name = "remove_source_branch")]
        public bool RemoveSourceBranch;

        [DataMember(Name = "labels")]
        public string Labels;

        [DataMember(Name = "squash")]
        public bool Squash;
    }
}