namespace MaslasBros.Snapshoting
{
    public interface ISnapshotModel
    {
        ///<summary>The SMRI of the snapshot this model is assocciated with.</summary>
        public uint SnapshotSMRI { get; }

        ///<summary>The SMRIs of assocciated snapshots to this model.</summary>
        public List<uint> refSMRIs { get; set; }
    }
}