﻿using MyApp.Domain.Core.Models;
using System;
using System.Collections.Generic;

namespace MyApp.Domain.Models
{
    public class Project : Entity
    {
        public Project() { }

        public Project(Guid id, string name, string description, DateTime completionDate, bool active, Client client)
        {
            Id = id;
            Name = name;
            Description = description;
            CompletionDate = completionDate;
            Active = active;
            Client = client;
            ProjectMembers = new List<ProjectMember>();
        }

        public string Name { get; private set; }
        public string Description { get; private set; }
        public DateTime CompletionDate { get; private set; }
        public bool Active { get; private set; }
        public Client Client { get; private set; }
        public IEnumerable<ProjectMember> ProjectMembers { get; set; }
    }
}
