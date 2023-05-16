namespace MaslasBros.Snapshoting
{
    public interface ISnapshot
    {
        ///<summary>The SMRI of this instance</summary>
        public uint sMRI { get; }

        ///<summary>
        /// Call upon construction to subscribe this instance to the Snapshot Manager
        /// <para>Primarily used in saving</para>
        /// </summary>
        public uint RegisterToManager();

        ///<summary>
        /// Call upon construction to subscribe this instance to the Snapshot Manager with a deserialized SMRI and ISnapshotModel.
        /// <para>Primarily used in loading</para>
        /// </summary>
        public uint RegisterToManager(uint loadedSMRI, ISnapshotModel model);

        /// <summary>
        /// Call after registering the ISnapshot to the manager to make it retrieve the references SMRIs of it.
        /// <para>Primarily used in loading</para>
        /// </summary>
        public void RetrieveReferences();

        ///<summary>Call to update the ISnapshotModel associated with this ISnapshot instance through the Snapshot Manager.</summary>
        public void UpdateToManager();

        ///<summary>Removes this instance from the Snapshot Manager cache and events.</summary>
        public void RemoveFromManager();
    }
}