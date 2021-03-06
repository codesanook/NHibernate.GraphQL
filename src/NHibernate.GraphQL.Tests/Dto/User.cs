﻿using System;
using System.Collections.Generic;

namespace NHibernate.GraphQL.Tests.Dto
{
    public class User
    {
        public virtual int Id { get; set; }

        public virtual string Login { get; set; }

        public virtual string FirstName { get; set; }

        public virtual string LastName { get; set; }

        public virtual string Email { get; set; }

        public virtual bool EmailIsConfirmed { get; set; }

        public virtual string PasswordHash { get; set; }

        public virtual DateTime CreatedAt { get; set; }

        public virtual DateTime? RemovedAt { get; set; }

        private ISet<Role> _roles;
        public virtual ISet<Role> Roles {
            get { return _roles ?? (_roles = new HashSet<Role>()); }
            protected set { _roles = value; }
        }

        public virtual Address Address { get; set; }
    }
}
