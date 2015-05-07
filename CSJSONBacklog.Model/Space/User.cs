﻿/* See the file "LICENSE" for the full license governing this code. */

using System;
using System.Collections.Generic;

namespace CSJSONBacklog.Model.Space
{
    /// <summary>
    /// User
    /// </summary>
    /// <see cref="http://developer.nulab-inc.com/docs/backlog/api/2/add-user"/>
    public class User : IEquatable<User>
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        public string Name { get; set; }
        public RoleType RoleType { get; set; }
        public string Lang { get; set; }
        public string MailAddress { get; set; }

        public override string ToString()
        {
            return string.Format("User: {0}({1})", Name, UserId);
        }

        #region Equals

        public bool Equals(User other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;
            return Id == other.Id && string.Equals(UserId, other.UserId) && string.Equals(Name, other.Name) && RoleType == other.RoleType && string.Equals(Lang, other.Lang) && string.Equals(MailAddress, other.MailAddress);
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return Equals((User) obj);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                int hashCode = Id;
                hashCode = (hashCode*397) ^ (UserId != null ? UserId.GetHashCode() : 0);
                hashCode = (hashCode*397) ^ (Name != null ? Name.GetHashCode() : 0);
                hashCode = (hashCode*397) ^ (int) RoleType;
                hashCode = (hashCode*397) ^ (Lang != null ? Lang.GetHashCode() : 0);
                hashCode = (hashCode*397) ^ (MailAddress != null ? MailAddress.GetHashCode() : 0);
                return hashCode;
            }
        }

        public static bool operator ==(User left, User right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(User left, User right)
        {
            return !Equals(left, right);
        }

        private sealed class UserEqualityComparer : IEqualityComparer<User>
        {
            public bool Equals(User x, User y)
            {
                if (ReferenceEquals(x, y)) return true;
                if (ReferenceEquals(x, null)) return false;
                if (ReferenceEquals(y, null)) return false;
                if (x.GetType() != y.GetType()) return false;
                return x.Id == y.Id && string.Equals(x.UserId, y.UserId) && string.Equals(x.Name, y.Name) && x.RoleType == y.RoleType && string.Equals(x.Lang, y.Lang) && string.Equals(x.MailAddress, y.MailAddress);
            }

            public int GetHashCode(User obj)
            {
                unchecked
                {
                    int hashCode = obj.Id;
                    hashCode = (hashCode*397) ^ (obj.UserId != null ? obj.UserId.GetHashCode() : 0);
                    hashCode = (hashCode*397) ^ (obj.Name != null ? obj.Name.GetHashCode() : 0);
                    hashCode = (hashCode*397) ^ (int) obj.RoleType;
                    hashCode = (hashCode*397) ^ (obj.Lang != null ? obj.Lang.GetHashCode() : 0);
                    hashCode = (hashCode*397) ^ (obj.MailAddress != null ? obj.MailAddress.GetHashCode() : 0);
                    return hashCode;
                }
            }
        }

        private static readonly IEqualityComparer<User> UserComparerInstance = new UserEqualityComparer();

        public static IEqualityComparer<User> UserComparer
        {
            get { return UserComparerInstance; }
        }

        #endregion Equals
    }

    /// <summary>
    /// <para>RoleType</para>
    /// <para>Administrator(1) Normal User(2) Reporter(3) Viewer(4) Guest Reporter(5) Guest Viewer(6)</para>
    /// </summary>
    /// <see cref="http://developer.nulab-inc.com/docs/backlog/api/2/add-user"/>
    public enum RoleType
    {
        None = 0,
        Administrator = 1,
        NormalUser = 2,
        Reporter = 3,
        Viewer = 4,
        GuestReporter = 5,
        GuestViewer = 6,
    }
}
