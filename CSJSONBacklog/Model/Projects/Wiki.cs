/* See the file "LICENSE" for the full license governing this code. */

using System;
using System.Collections.Generic;
using CSJSONBacklog.Model.Space;

namespace CSJSONBacklog.Model.Projects
{
    public class WikiPage : IEquatable<WikiPage>
    {
        public int Id { get; set; }
        public int ProjectId { get; set; }
        public string Name { get; set; }
        public string Content { get; set; }
        public List<Tag> Tags { get; set; }
        public User CreatedUser { get; set; }
        public string Created { get; set; }
        public User UpdatedUser { get; set; }
        public DateTime Updated { get; set; }

        public override string ToString()
        {
            return string.Format("WikiPage: {0}({1})", Name, Id);
        }

        #region Equals

        public bool Equals(WikiPage other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;
            return Id == other.Id && ProjectId == other.ProjectId && string.Equals(Name, other.Name) && string.Equals(Content, other.Content) && Extensions.EnumerableEqualityExtension.ScrambledEquals(Tags, other.Tags) && Equals(CreatedUser, other.CreatedUser) && string.Equals(Created, other.Created) && Equals(UpdatedUser, other.UpdatedUser) && Updated.Equals(other.Updated);
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return Equals((WikiPage) obj);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                int hashCode = Id;
                hashCode = (hashCode*397) ^ ProjectId;
                hashCode = (hashCode*397) ^ (Name != null ? Name.GetHashCode() : 0);
                hashCode = (hashCode*397) ^ (Content != null ? Content.GetHashCode() : 0);
                hashCode = (hashCode*397) ^ (Tags != null ? Tags.GetHashCode() : 0);
                hashCode = (hashCode*397) ^ (CreatedUser != null ? CreatedUser.GetHashCode() : 0);
                hashCode = (hashCode*397) ^ (Created != null ? Created.GetHashCode() : 0);
                hashCode = (hashCode*397) ^ (UpdatedUser != null ? UpdatedUser.GetHashCode() : 0);
                hashCode = (hashCode*397) ^ Updated.GetHashCode();
                return hashCode;
            }
        }

        public static bool operator ==(WikiPage left, WikiPage right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(WikiPage left, WikiPage right)
        {
            return !Equals(left, right);
        }

        private sealed class WikiPageEqualityComparer : IEqualityComparer<WikiPage>
        {
            public bool Equals(WikiPage x, WikiPage y)
            {
                if (ReferenceEquals(x, y)) return true;
                if (ReferenceEquals(x, null)) return false;
                if (ReferenceEquals(y, null)) return false;
                if (x.GetType() != y.GetType()) return false;
                return x.Id == y.Id && x.ProjectId == y.ProjectId && string.Equals(x.Name, y.Name) && string.Equals(x.Content, y.Content) && Equals(x.Tags, y.Tags) && Equals(x.CreatedUser, y.CreatedUser) && string.Equals(x.Created, y.Created) && Equals(x.UpdatedUser, y.UpdatedUser) && x.Updated.Equals(y.Updated);
            }

            public int GetHashCode(WikiPage obj)
            {
                unchecked
                {
                    int hashCode = obj.Id;
                    hashCode = (hashCode*397) ^ obj.ProjectId;
                    hashCode = (hashCode*397) ^ (obj.Name != null ? obj.Name.GetHashCode() : 0);
                    hashCode = (hashCode*397) ^ (obj.Content != null ? obj.Content.GetHashCode() : 0);
                    hashCode = (hashCode*397) ^ (obj.Tags != null ? obj.Tags.GetHashCode() : 0);
                    hashCode = (hashCode*397) ^ (obj.CreatedUser != null ? obj.CreatedUser.GetHashCode() : 0);
                    hashCode = (hashCode*397) ^ (obj.Created != null ? obj.Created.GetHashCode() : 0);
                    hashCode = (hashCode*397) ^ (obj.UpdatedUser != null ? obj.UpdatedUser.GetHashCode() : 0);
                    hashCode = (hashCode*397) ^ obj.Updated.GetHashCode();
                    return hashCode;
                }
            }
        }

        private static readonly IEqualityComparer<WikiPage> WikiPageComparerInstance = new WikiPageEqualityComparer();

        public static IEqualityComparer<WikiPage> WikiPageComparer
        {
            get { return WikiPageComparerInstance; }
        }

        #endregion Equals
    }

    public class Tag : IEquatable<Tag>
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public override string ToString()
        {
            return string.Format("Tag: {0}({1})", Name, Id);
        }

        #region Equals

        public bool Equals(Tag other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;
            return Id == other.Id && string.Equals(Name, other.Name);
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return Equals((Tag) obj);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                return (Id*397) ^ (Name != null ? Name.GetHashCode() : 0);
            }
        }

        public static bool operator ==(Tag left, Tag right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(Tag left, Tag right)
        {
            return !Equals(left, right);
        }

        private sealed class IdNameEqualityComparer : IEqualityComparer<Tag>
        {
            public bool Equals(Tag x, Tag y)
            {
                if (ReferenceEquals(x, y)) return true;
                if (ReferenceEquals(x, null)) return false;
                if (ReferenceEquals(y, null)) return false;
                if (x.GetType() != y.GetType()) return false;
                return x.Id == y.Id && string.Equals(x.Name, y.Name);
            }

            public int GetHashCode(Tag obj)
            {
                unchecked
                {
                    return (obj.Id*397) ^ (obj.Name != null ? obj.Name.GetHashCode() : 0);
                }
            }
        }

        private static readonly IEqualityComparer<Tag> IdNameComparerInstance = new IdNameEqualityComparer();

        public static IEqualityComparer<Tag> IdNameComparer
        {
            get { return IdNameComparerInstance; }
        }

        #endregion Equals
    }
}
