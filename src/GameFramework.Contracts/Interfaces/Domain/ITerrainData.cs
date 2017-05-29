using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameFramework.Contracts.Interfaces.Domain
{
    /// <summary>
    /// The terrain data definition
    /// </summary>
    public interface ITerrainData
    {
        /// <summary>
        /// The database id.
        /// </summary>
        int Id { get; set; }
        /// <summary>
        /// The name of the terrain
        /// </summary>
        string Name { get; set; }
        /// <summary>
        /// The modifier of metal resources available for terrain
        /// </summary>
        int Metal { get; set; }
        /// <summary>
        /// The modifier of gas resources available for terrain
        /// </summary>
        int Gas { get; set; }
        /// <summary>
        /// The modifier of crystals resources available for terrain
        /// </summary>
        int Crystals { get; set; }
        /// <summary>
        /// The modifier of fertility resources available for terrain
        /// </summary>
        int Fertility { get; set; }
        /// <summary>
        /// The modifier of area lower limit
        /// </summary>
        int AreaPlanet { get; set; }
        /// <summary>
        /// The modifier of area upper limit
        /// </summary>
        int AreaMoon { get; set; }
    }
}
