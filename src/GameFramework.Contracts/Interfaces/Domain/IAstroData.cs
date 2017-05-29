namespace GameFramework.Contracts.Interfaces.Domain
{
    /// <summary>
    /// Astro Data Definition
    /// </summary>
    public interface IAstroData
    {
        /// <summary>
        /// The database id field
        /// </summary>
        int Id { get; set; }
        /// <summary>
        /// The galaxy location 00:99
        /// </summary>
        int Galaxy { get; set; }
        /// <summary>
        /// The region location 00:99
        /// </summary>
        int Region { get; set; }
        /// <summary>
        /// The system location 00:99
        /// </summary>
        int System { get; set; }
        /// <summary>
        /// The position location 00:99
        /// </summary>
        int Position { get; set; }
        /// <summary>
        /// The astro type <see cref="AstroType"/>
        /// </summary>
        AstroType Type { get; set; }
        /// <summary>
        /// The terrain data <see cref="ITerrainData"/> and <see cref="GameFramework.Contracts.Abstractions.Domain.TerrainData"/>
        /// </summary>
        ITerrainData Terrain { get; set; }
    }
}
