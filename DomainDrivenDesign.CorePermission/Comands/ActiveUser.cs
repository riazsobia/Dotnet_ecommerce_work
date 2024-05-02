﻿using System;
using DomainDrivenDesign.Core.Commands;
using DomainDrivenDesign.Core.Implements.Commands;

namespace DomainDrivenDesign.CorePermission.Comands
{
    public class ActiveUser : AdminBaseCommand
    {
        public Guid Id { get; }

        public ActiveUser(Guid id
            ,Guid userId,DateTime createdDate):base(userId,createdDate)
        {
            Id = id;
        }
        
    }
}