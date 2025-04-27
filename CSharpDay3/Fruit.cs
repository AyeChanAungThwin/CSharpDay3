namespace CSharpDay3
{
    public class Fruit
    {

        public Fruit(string name, string description)
        {
            Name = name;
            Description = description;
        }
        
        public string Name { get; set; }
        public string Description { get; set; }

        protected bool Equals(Fruit other)
        {
            return Name == other.Name && Description == other.Description;
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return Equals((Fruit)obj);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                return ((Name != null ? Name.GetHashCode() : 0) * 397) ^ (Description != null ? Description.GetHashCode() : 0);
            }
        }
    }
}