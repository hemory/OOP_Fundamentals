namespace ACM.BL
{
    public abstract class EntityBase //abstract makes it so that it can only be used as a base class
    {
        public enum EntityStateOption
        {
            Active,
            Deleted
        }

        public bool IsNew { get; private set; }
        public bool HasChanges { get; set; }
        public EntityStateOption EntityState { get; set; }
        public bool IsValid => Validate();

        public abstract bool Validate();
    }
}