using GameFramework.Contracts.Interfaces.Domain;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GameFramework.Contracts.Abstractions.Domain
{
    public abstract class TerrainData : ITerrainData
    {
        /// <summary>
        /// The database id keyed and database generated
        /// </summary>
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id {get;set;}
        /// <summary>
        /// <see cref="ITerrainData.Name"/>
        /// </summary>
        public string Name {get;set;}
        /// <summary>
        /// <see cref="ITerrainData.Metal"/>
        /// </summary>
        public int Metal {get;set;}
        /// <summary>
        /// <see cref="ITerrainData.Gas"/>
        /// </summary>
        public int Gas {get;set;}
        /// <summary>
        /// <see cref="ITerrainData.Crystals"/>
        /// </summary>
        public int Crystals {get;set;}
        /// <summary>
        /// <see cref="ITerrainData.Fertility"/>
        /// </summary>
        public int Fertility {get;set;}
        /// <summary>
        /// <see cref="ITerrainData.AreaPlanet"/>
        /// </summary>
        public int AreaPlanet {get;set;}
        /// <summary>
        /// <see cref="ITerrainData.AreaMoon"/>
        /// </summary>
        public int AreaMoon {get;set;}

        /// <summary>
        /// The default constructor
        /// </summary>
        /// <param name="name"><see cref="ITerrainData.Name"/></param>
        /// <param name="metal"><see cref="ITerrainData.Metal"/></param>
        /// <param name="gas"><see cref="ITerrainData.Gas"/></param>
        /// <param name="crystals"><see cref="ITerrainData.Crystals"/></param>
        /// <param name="fertility"><see cref="ITerrainData.Fertility"/></param>
        /// <param name="upper"><see cref="ITerrainData.AreaPlanet"/></param>
        /// <param name="lower"><see cref="ITerrainData.AreaMoon"/></param>
        protected TerrainData(string name, int metal, int gas, int crystals, int fertility, int upper, int lower)
        {
            Name = name;
            Metal = metal;
            Gas = gas;
            Crystals = crystals;
            Fertility = fertility;
            AreaMoon = upper;
            AreaPlanet = lower;
        }
    }
}
