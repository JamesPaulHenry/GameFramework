using GameFramework.Contracts.Interfaces.Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameFramework.Contracts.Abstractions.Domain
{

    public abstract class AstroData : IAstroData
    {
        /// <summary>
        /// <see cref="IAstroData.Id"/>
        /// </summary>
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id {get;set;}
        /// <summary>
        /// <see cref="IAstroData.Galaxy"/>
        /// </summary>
        public int Galaxy {get;set;}
        /// <summary>
        /// <see cref="IAstroData.Region"/>
        /// </summary>
        public int Region {get;set;}
        /// <summary>
        /// <see cref="IAstroData.System"/>
        /// </summary>
        public int System {get;set;}
        /// <summary>
        /// <see cref="IAstroData.Position"/>
        /// </summary>
        public int Position {get;set;}
        /// <summary>
        /// <see cref="IAstroData.Type"/>
        /// </summary>
        public AstroType Type {get;set;}
        /// <summary>
        /// <see cref="IAstroData.Terrain"/>
        /// </summary>
        public ITerrainData Terrain {get;set;}

        /// <summary>
        /// 
        /// </summary>
        /// <param name="galaxy"><see cref="IAstroData.Galaxy"/></param>
        /// <param name="region"><see cref="IAstroData.Region"/></param>
        /// <param name="system"><see cref="IAstroData.System"/></param>
        /// <param name="position"><see cref="IAstroData.Position"/></param>
        /// <param name="type"><see cref="IAstroData.Type"/></param>
        /// <param name="terrain"><see cref="IAstroData.Terrain"/></param>
        protected AstroData(int galaxy, int region, int system, int position, AstroType type, ITerrainData terrain)
        {
            Galaxy = galaxy;
            Region = region;
            System = system;
            Position = position;
            Type = type;
            Terrain = terrain;
        }
    }
}
